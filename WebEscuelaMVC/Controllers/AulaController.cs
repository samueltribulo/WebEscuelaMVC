using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private readonly EscuelaDbContext _context;

        public AulaController(EscuelaDbContext _context)
        {
            this._context = _context;
        }


        public IActionResult Index()
        {
            var aulas = _context.Aulas.ToList();

            return View(aulas);

        }

        [HttpGet]
        public ActionResult Create()
        {
            Aula aula = new Aula();
            return View("Register", aula);
        }

        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                _context.Aulas.Add(aula);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aula);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var aula = _context.Aulas.Find(id);

            if (aula == null) return NotFound();

            return View(aula);

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {

            var aula = _context.Aulas.Find(id);

            if (aula == null) return NotFound();

            return View("Edit");

        }

        [HttpPost]
        public ActionResult Edit( Aula aula )
        {


            if (!ModelState.IsValid) return BadRequest();

            _context.Entry(aula).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var aula = _context.Aulas.Find(id);
            if (aula == null)
                return NotFound();
            else
                return View("Delete", aula);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var aula = _context.Aulas.Find(id);
            if (aula == null)
                return NotFound();
            else
            {
                _context.Aulas.Remove(aula);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
