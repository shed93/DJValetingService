﻿namespace DJValetingService.Models
{
    public class ValetingRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BookingDate { get; set; }
        public Ref_FlexibilityViewModel Flexibility { get; set; }
        public Ref_VehicleSize VehicleSize { get; set; }    
        public string ContactNumber { get; set; }   
        public string EmailAddress { get; set; }
        public DateTime InsertStamp { get; set; }
        public DateTime UpdateStamp { get; set; }
        public bool Removed { get; set; }
        public bool Approved { get; set; }
    }
}
