using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "AD ALANI ZORUNLU")]
        public string? Name { get; set; } //null

        [Required]
        public string? Phone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "HATALI EMAİL")]
        public string? Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; } //true, false, null
    }
}