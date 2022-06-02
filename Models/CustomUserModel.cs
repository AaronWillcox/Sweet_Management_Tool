using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Sweet_Management_Tool.Models
{
    public class CustomUserModel : IdentityUser
    {
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Sname { get; set; }
    }
}
