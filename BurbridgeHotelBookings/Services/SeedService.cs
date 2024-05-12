using BurbridgeHotelBookings.Data;
using BurbridgeHotelBookings.Enums;
using Microsoft.AspNetCore.Identity;

namespace BurbridgeHotelBookings.Services
{
    public class SeedService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoleStore<IdentityRole> _roleStore;
        private readonly IConfiguration _configuration;

        public SeedService(UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore,
                         RoleManager<IdentityRole> roleManager, IRoleStore<IdentityRole> roleStore,IConfiguration configuration)
        {
            _userManager = userManager;
            _userStore = userStore;
            _roleManager = roleManager;
            _roleStore = roleStore;
            _configuration = configuration;
        }

        public async Task SeedDatabaseAsync()
        {
            var adminUserRole = _configuration.GetValue<string>("AdminUser:Email");
            var dbAdminUser = await _userManager.FindByEmailAsync(adminUserRole!);
            if (dbAdminUser is not null)
                return;

            var applicationUser = new ApplicationUser()
            {
                FirtName = _configuration.GetValue<string>("AdminUser:FirstName")!,
                LastName = _configuration.GetValue<string>("AdminUser:LastName"),
                RoleName = RoleTypes.Admin.ToString(),
                ContactNumber = _configuration.GetValue<string>("AdminUser:ContactNumer")!,
                Designation =  "Adminstrator"
            };
        }
    }
    
}
