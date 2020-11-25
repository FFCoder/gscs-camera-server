using System.ComponentModel.DataAnnotations;

namespace CameraServer.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required] public School School { get; set; }
        [Required] [MaxLength(30)] public string RoomName { get; set; }
    }
}