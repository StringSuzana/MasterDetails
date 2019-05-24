using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetails.Models
{
    public class Seminar
    {
        [Key]
        public int SeminarId { get; set; }
        [Required]
        public string SeminarName { get; set; }
       
        public ICollection<Student> Student { get; set; }

    }
}