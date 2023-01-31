using Microsoft.AspNetCore.Mvc;
using System;

namespace WebEscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Saludo = "Bienvenido al Sistema de Escuela";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
        public  IActionResult About()
        {
            return View();
        }
    }
}
