using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MasterDetails.Models;

namespace MasterDetails.Context
{
    public class WorkingDatabase : DbContext
    {
        public WorkingDatabase()
            :base("VjezbaViewModela")
        {

        }
        public DbSet<Seminar> Seminar { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}