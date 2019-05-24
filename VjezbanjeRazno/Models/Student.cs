using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetails.Models
{

    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public Seminar Seminar { get; set; }
        public int SeminarId { get; set; }

    }
}