﻿using System;
using System.ComponentModel.DataAnnotations;

namespace maryedesigns.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Role { get; set; }

        public DateTime Year { get; set; } = DateTime.Now;

        public string UserId { get; set; }
    }
}
