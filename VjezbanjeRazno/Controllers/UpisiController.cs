using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VjezbanjeRazno.DAL;
using VjezbanjeRazno.Models;

namespace VjezbanjeRazno.Controllers
{
    public class UpisiController : Controller
    {
        SveRepo repo = new SveRepo();
        // GET: Upisi
        public ActionResult IspisStudenata()
        {  

        List<Student> listaStudenata = repo.ListaSvihStudenata();
            List<Seminar> listaSeminara= new List<Seminar>();

            List<int> listaBrojeva = new List<int>();
            foreach (var x in listaStudenata)
            {               
                listaBrojeva.Add(x.SeminarId);
            }
            foreach(var x in listaBrojeva)
            {
                var seminar = repo.ListaSvihSeminara().FirstOrDefault(m => m.SeminarId == x);
                listaSeminara.Add(seminar);
            }            
            SeminarStudentViewModel viewModelList = new SeminarStudentViewModel
            {              
            Student= listaStudenata,
            Seminar = listaSeminara
            };

            return View(viewModelList);
        }
    }
}