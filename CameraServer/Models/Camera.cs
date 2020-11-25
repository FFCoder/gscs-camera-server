using System.ComponentModel.DataAnnotations;

namespace CameraServer.Models
{
    public class Camera
    {
        [Key]
        public int CameraId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public CameraModel Model { get; set; }
        [Required] 
        public string IpAddress { get; set; }
        [Required] public Room Room { get; set; }
        

    }
}