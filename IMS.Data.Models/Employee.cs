﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static IMS.Common.EntityValidationConstants.Employee;

namespace IMS.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [Range(MinYOFLength, MaxYOFLength)]
        public int YearsOfExperience { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public int? CommercialSiteId { get; set; }

        [ForeignKey(nameof(CommercialSiteId))]
        public CommercialSite? CommercialSite { get; set; }

        [Required]
        public bool IsApproved { get; set; } = false;
    }
}
