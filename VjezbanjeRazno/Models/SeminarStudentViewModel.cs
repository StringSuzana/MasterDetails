using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetails.Models
{
    public class SeminarStudentViewModel
    { 
        public List<Seminar> Seminar { get; set; }
        public List<Student> Student { get; set; }
   
        
    }


}