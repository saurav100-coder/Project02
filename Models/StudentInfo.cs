using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Project02.Models
{
    public class StudentInfo
    {
        [Key] 
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set;} = string.Empty;
        [Required]
        public string Class { get; set; } = string.Empty;
    }
}
