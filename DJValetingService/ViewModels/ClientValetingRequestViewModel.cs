namespace DJValetingService.Models
{
    public class ClientValetingRequestViewModel
    {
        public string Name { get; set; }
        public DateTime BookingDate { get; set; }
        public int FlexibilityId { get; set; }
        public int VehicleSizeId { get; set; }    
        public string ContactNumber { get; set; }   
        public string EmailAddress { get; set; }       
    }
}
