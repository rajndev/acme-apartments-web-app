﻿using AcmeApartments.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AcmeApartments.BLL.DTOs
{
    public class MaintenanceRequestDTO
    {
        //todo-p delete the files named "delete" at the end
        public int Id { get; set; }

        public string AptUserId { get; set; }

        [Required]
        [MaxLength(10000)]
        [Display(Name = "Problem Description")]
        public string ProblemDescription { get; set; }

        [DisplayName("Permitted to enter the apartment?")]
        public bool isAllowedToEnter { get; set; }

        public bool isSuccess { get; set; }
        public string userFName { get; set; }
        public string userLName { get; set; }

        public MaintenanceRequest mRequest { get; set; }
        public List<MaintenanceRequest> mRequests { get; set; }
    }
}