﻿using System.ComponentModel.DataAnnotations;

namespace React_Student_clint.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string? stname { get; set; }
        public string? course { get; set; }
    }
}
