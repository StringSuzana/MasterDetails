using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasterDetails.DAL;
using MasterDetails.Models;

namespace MasterDetails.Controllers
{
    public class StudentsController : Controller
    {
        SeminarStudentRepo repo = new SeminarStudentRepo();
        // GET: Upisi
        public ActionResult ListOfStudentsWithSeminars()
        {  

        List<Student> listaStudenata = repo.ListOfAllStudents();
            List<Seminar> listaSeminara= new List<Seminar>();

            List<int> listaBrojeva = new List<int>();
            foreach (var x in listaStudenata)
            {               
                listaBrojeva.Add(x.SeminarId);
            }
            foreach(var x in listaBrojeva)
            {
                var seminar = repo.ListOfAllSeminars().FirstOrDefault(m => m.SeminarId == x);
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