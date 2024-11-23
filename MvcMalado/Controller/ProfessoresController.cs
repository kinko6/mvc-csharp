using MvcMalado.Data;
using MvcMalado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MvcMalado.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly EscolaContext _context;

        public ProfessoresController(EscolaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var professores = _context.Professores.ToList();
            return View(professores);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Professores.Add(professor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(professor);
        }
    }
}
