using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BurbridgeHotelBookings.Data.Entites
{
    public class Room 
    {
        [Key]
        public int Id { get; set; }

        public short RoomCatagoryId { get; set; }

        [Required, MinLength(25), Unicode(false)]
        public string RoomNumber { get; set; }

        public bool IsAvaiable { get; set; }

        public  virtual RoomCatagory RoomCatagory { get; set; }


    }
}
