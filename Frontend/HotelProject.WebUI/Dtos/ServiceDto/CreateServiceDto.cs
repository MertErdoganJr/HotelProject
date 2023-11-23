using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Please Enter Image URL")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        [StringLength(100, ErrorMessage ="Max Length 100")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }
    }
}
