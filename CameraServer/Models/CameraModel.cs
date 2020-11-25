using System.ComponentModel.DataAnnotations;

namespace CameraServer.Models
{
    public class CameraModel
    {
        [Key]
        public int ModelId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string StaticImageUrl { get; set; }
        public string OpenLensCommand { get; set; }
        public string CloseLensCommand { get; set; }
        
    }
}