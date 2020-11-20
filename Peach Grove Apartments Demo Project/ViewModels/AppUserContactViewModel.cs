﻿using System.ComponentModel.DataAnnotations;

namespace Peach_Grove_Apartments_Demo_Project.ViewModels
{
    public class AppUserContactViewModel
    {
        [Required]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Your Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Message { get; set; }
    }
}