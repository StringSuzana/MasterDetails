using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VjezbanjeRazno.Models
{
    public class SeminarViewModel
    {
        public int SeminarId { get; set; }
        public string Naziv { get; set; }
        public bool Polozen { get; set; }
    }
}