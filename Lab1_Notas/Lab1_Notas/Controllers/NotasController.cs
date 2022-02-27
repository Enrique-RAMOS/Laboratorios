using Lab1_Notas.Bussines;
using Lab1_Notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_Notas.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult index_(Acciones acciones )
        {

            Operaciones op = new Operaciones();
            double resultado = op.index(acciones);
            
            ViewBag.variableaenviar = resultado;
            
            return View();
        }
       
    }
}
