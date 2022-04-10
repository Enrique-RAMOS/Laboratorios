using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Service;

namespace Practica01.Controllers
{
    public class StudentsController : Controller
    {

        private IEstudiante Estudiante;

        public StudentsController(IEstudiante estudiante)
        {
            Estudiante = estudiante;
        }

        public IActionResult Delete(int id) {
            Estudiantes es = new Estudiantes();
            es.Id = id;
            Estudiante.DeleteStudents(es);

            return RedirectToAction("Index");
        }

        public IActionResult Load(int id) {
            Estudiantes es = new Estudiantes();
            es.Id=id;
           var listarestudiante= Estudiante.LoadInformation(es);

            return View(listarestudiante);
        }

        public IActionResult actu(Estudiantes es) {

            Estudiante.UpdateStudents(es);
            return RedirectToAction("Index");

        }


        public IActionResult Guardar() { 

            
        
            return View();
        }

        public IActionResult Save(Estudiantes es) {

            Estudiante.AddStudents(es);
            return RedirectToAction("Index");

        }

       
        public IActionResult Index()
        {
           
            var listar = Estudiante.GetAll();
           
            return View(listar);
        }
        [HttpPost]
        public IActionResult Insertardata(Estudiantes es)  { 

        return RedirectToAction("Index");
       // return View("Index");
        
        }
    }
}
