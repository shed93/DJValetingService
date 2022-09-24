using System.Drawing;

namespace DJValetingService.Models
{
    public class Ref_FlexibilityViewModel
    {
        public Ref_FlexibilityViewModel(Ref_Flexibility s)
        {
            Id = s.Id;
            Flexibility = s.Flexibility;
        }
        public int Id { get; set; } 
        public string Flexibility { get; set; }
    }
}
