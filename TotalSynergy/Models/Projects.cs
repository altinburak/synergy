﻿using System.ComponentModel.DataAnnotations;

namespace TotalSynergy.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}