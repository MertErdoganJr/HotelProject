using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please Enter Room Number")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Room Image")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please Enter Room Price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        [StringLength(100, ErrorMessage = "Please enter a maximum of 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Bed Number")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please Enter Bath Number")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }
    }
}
