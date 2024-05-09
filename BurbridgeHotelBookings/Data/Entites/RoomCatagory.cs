
using BurbridgeHotelBookings.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurbridgeHotelBookings.Data.Entites
{
    public class RoomCatagory : Audiable
    {
        public short Id { get; set; }
        public string Name { get; set; }

        [Required, MaxLength(100), Unicode(false)]
        public string Image { get; set; }

        [Required, Range(1, double.MaxValue)]
        public decimal Price { get; set; }

        [Required, MaxLength(200)]
        public string Decsription { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChilds { get; set; }


        public bool IsActive { get; set; }

        [ForeignKey(nameof(AddedBy))]
        public virtual ApplicationUser? AddedByUser { get; set; }

        public virtual ICollection<RoomCatagoryAmenity> Amenities { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
