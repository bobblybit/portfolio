﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.Models
{
    public class Project
    {
        public int ID { get; set; }
        public User implementedBy { get; set; }
        public int userID { get; set; }
        public string projectTitle { get; set; }
        public string projectImageUrl { get; set; }
        public string projectDescription { get; set; }
    }
}