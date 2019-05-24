using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VjezbanjeRazno.Context;
using VjezbanjeRazno.Models;

namespace VjezbanjeRazno.DAL
{
    public class SveRepo
    {
        //BazaPodataka baza = new BazaPodataka();

        public List<Seminar> ListaSvihSeminara()
        {
            using (var db = new BazaPodataka())
            {
                return db.Seminar.ToList();

            }
        }

        public void UnesiNoviSeminar(Seminar model)
        {
            using (var db = new BazaPodataka())
            {
                //nema validacija podataka za upis radi jednostavnosti vjezbe
                if(model.Naziv!= null)
                {
                    db.Seminar.Add(model);
                    db.SaveChanges();
                }

            }
        }

        public List<Student> ListaSvihStudenata()
        {
            using (var db = new BazaPodataka())
            {
                return db.Student.ToList();

            }
        }
       

    }
}