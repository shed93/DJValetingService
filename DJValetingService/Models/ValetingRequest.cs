namespace DJValetingService.Models
{
    public class ValetingRequest
    {
        public ValetingRequest(ClientValetingRequestViewModel clientValetingRequestViewModel)
        {
            Name = clientValetingRequestViewModel.Name;
            BookingDate = clientValetingRequestViewModel.BookingDate;
            FlexibilityId = clientValetingRequestViewModel.FlexibilityId;
            VehicleSizeId = clientValetingRequestViewModel.VehicleSizeId;
            ContactNumber = clientValetingRequestViewModel.ContactNumber;
            EmailAddress = clientValetingRequestViewModel.EmailAddress;
            InsertStamp = DateTime.Now;
            UpdateStamp = DateTime.Now;
            Removed = false;
            Approved = false;
        }
        public ValetingRequest(AdminValetingRequestViewModel adminValetingRequestViewModel)
        {
            Id = adminValetingRequestViewModel.Id;
            Name = adminValetingRequestViewModel.Name;
            BookingDate = adminValetingRequestViewModel.BookingDate;
            FlexibilityId = adminValetingRequestViewModel.FlexibilityId;
            VehicleSizeId = adminValetingRequestViewModel.VehicleSizeId;
            ContactNumber = adminValetingRequestViewModel.ContactNumber;
            EmailAddress = adminValetingRequestViewModel.EmailAddress;
            UpdateStamp = DateTime.Now;
            Removed = false;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BookingDate { get; set; }
        public int FlexibilityId { get; set; }
        public Ref_FlexibilityViewModel Flexibility { get; set; }
        public int VehicleSizeId { get; set; }
        public Ref_VehicleSize VehicleSize { get; set; }    
        public string ContactNumber { get; set; }   
        public string EmailAddress { get; set; }
        public DateTime InsertStamp { get; set; }
        public DateTime UpdateStamp { get; set; }
        public bool Removed { get; set; }
        public bool Approved { get; set; }
    }
}
