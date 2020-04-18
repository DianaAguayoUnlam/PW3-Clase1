using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibliotecaClases;

namespace Aplicacion1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int resultado = Calculadora.Sumar("1000", "1000");
            ViewBag.suma = resultado;
            return View();
        }

        public ActionResult Duplicar(int id)
        {
            int resultado = id * 2;
            ViewBag.num = id;
            ViewBag.duplicado = resultado;
            return View();
        }
    }
}