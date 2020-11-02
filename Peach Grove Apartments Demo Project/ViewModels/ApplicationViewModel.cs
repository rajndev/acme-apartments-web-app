﻿using Peach_Grove_Apartments_Demo_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Peach_Grove_Apartments_Demo_Project.ViewModels
{
    public class ApplicationViewModel
    {

        public IList<Application> Apps { get; set; }

        [Display(Name = "Applicantion ID")]
        public int ApplicationId { get; set; }
      
        [Display(Name = "Applicant ID")]
        public string AptUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Applied")]
        public DateTime DateApplied { get; set; }
        [Required]
        public string Occupation { get; set; }
        public int? Income { get; set; }
        [Required]
        [Display(Name = "Reason for Moving")]
        public string ReasonForMoving { get; set; }
        [Required]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        public string SSN { get; set; }
        [Display(Name = "Apartment Number")]
        public string AptNumber { get; set; }
        public string Area { get; set; }
        public string Price { get; set; }
    }
}