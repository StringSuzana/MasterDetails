using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MasterDetails.Context;
using MasterDetails.Models;

namespace MasterDetails.DAL
{
    public class SeminarStudentRepo
    {
        //BazaPodataka baza = new BazaPodataka();

        public List<Seminar> ListOfAllSeminars()
        {
            using (var db = new WorkingDatabase())
            {
                return db.Seminar.ToList();

            }
        }

        public void UnesiNoviSeminar(Seminar model)
        {
            using (var db = new WorkingDatabase())
            {
                //nema validacija podataka za upis radi jednostavnosti vjezbe
                if(model.SeminarName!= null)
                {
                    db.Seminar.Add(model);
                    db.SaveChanges();
                }

            }
        }

        public List<Student> ListOfAllStudents()
        {
            using (var db = new WorkingDatabase())
            {
                return db.Student.ToList();

            }
        }
       

    }
}