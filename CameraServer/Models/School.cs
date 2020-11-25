using System.ComponentModel.DataAnnotations;

namespace CameraServer.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}