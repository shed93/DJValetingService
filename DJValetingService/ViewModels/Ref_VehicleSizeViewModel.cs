namespace DJValetingService.Models
{
    public class Ref_VehicleSizeViewModel
    {
        public Ref_VehicleSizeViewModel()
        {
        }
        public Ref_VehicleSizeViewModel(Ref_VehicleSize s)
        {
            Id = s.Id;
            Size = s.Size;
        }

        public int Id { get; set; } 
        public string Size { get; set; }
    }
}
