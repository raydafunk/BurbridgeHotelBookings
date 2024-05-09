using System.ComponentModel.DataAnnotations;

namespace BurbridgeHotelBookings.Data.Common
{
    public abstract class Audiable
    {
        public DateTime AddedOn { get; set; }

        [Required]
        public string AddedBy { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public DateTime? LastUpdatedBy { get; set; }
    }
}
