namespace BurbridgeHotelBookings.Data.Entites
{
    public class RoomCatagoryAmenity
    {
        public short RoomCatagoryId { get; set; }

        public int AmenityId { get; set; }
        public int? RoomUtilitiesNumber { get; set; } 
        public virtual RoomCatagory RoomCatagory { get; set; } 
        public virtual Amenity Amenity { get; set; } 
        
    }
}
