using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VjezbanjeRazno.Models
{

    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Ime { get; set; }
        public string Prezime { get; set; }


        public Seminar Seminar { get; set; }
        public int SeminarId { get; set; }

    }
}