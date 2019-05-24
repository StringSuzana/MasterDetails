using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VjezbanjeRazno.Models;

namespace VjezbanjeRazno.Context
{
    public class BazaPodataka: DbContext
    {
        public BazaPodataka()
            :base("VjezbaViewModela")
        {

        }
        public DbSet<Seminar> Seminar { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}