﻿using AcmeApartments.DAL.Models;
using System.Collections.Generic;

namespace AcmeApartments.BLL.DTOs
{
    public class ApplicationViewModelDTO
    {
        public IList<Application> Applications { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}