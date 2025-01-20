using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static IMS.Common.EntityValidationConstants.User;

namespace IMS.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(MaxNameLength)]
        [PersonalData]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxNameLength)]
        [PersonalData]
        public string LastName { get; set; } = null!;

        public Employee? Employee { get; set; }
    }
}
