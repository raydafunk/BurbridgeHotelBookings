using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BurbridgeHotelBookings.Data.Entites
{
    public class Amenity
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(25), Unicode(false)]
        public string Name { get; set; }

        [Required, MinLength(25), Unicode(false)]
        public string Icon { get; set; }
    }
}
