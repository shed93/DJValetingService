using System.Drawing;

namespace DJValetingService.Models
{
    public class Ref_FlexibilityViewModel
    {
        public Ref_FlexibilityViewModel(Ref_Flexibility ref_Flexibility)
        {
            Id = ref_Flexibility.Id;
            Flexibility = ref_Flexibility.Flexibility;
        }
        public Ref_FlexibilityViewModel()
        {
        }
        public int Id { get; set; } 
        public string Flexibility { get; set; }
    }
}
