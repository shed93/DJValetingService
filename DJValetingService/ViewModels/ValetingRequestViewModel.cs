namespace DJValetingService.Models
{
    public class ValetingRequestViewModel
    {
        public ValetingRequestViewModel(ValetingRequest valetingRequest)
        {
            Id = valetingRequest.Id;
            Name = valetingRequest.Name;
            BookingDate = valetingRequest.BookingDate;
            FlexibilityId = valetingRequest.FlexibilityId;
            VehicleSizeId = valetingRequest.VehicleSizeId;
            ContactNumber = valetingRequest.ContactNumber;
            EmailAddress = valetingRequest.EmailAddress;
            Approved = false;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BookingDate { get; set; }
        public int FlexibilityId { get; set; }
        public int VehicleSizeId { get; set; }    
        public string ContactNumber { get; set; }   
        public string EmailAddress { get; set; }
        public bool Approved { get; set; }
    }
}
