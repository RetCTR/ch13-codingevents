﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Must be a number between 0 and 100,000.")]
        public int Attendees { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

    }
}
