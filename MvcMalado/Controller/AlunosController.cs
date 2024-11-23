using Microsoft.AspNetCore.Mvc; // Necessário para Controller e IActionResult
using MvcMalado.Data; // Necessário para EscolaContext
using MvcMalado.Models; // Necessário para o modelo Aluno
using Microsoft.EntityFrameworkCore;


public class AlunosController : Controller
{
    private readonly EscolaContext _context;

    public AlunosController(EscolaContext context)
    {
        _context = context;
    }

    // GET: Alunos/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Alunos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Aluno aluno)
    {
        if (ModelState.IsValid)
        {
            _context.Add(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(aluno);
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Alunos.ToListAsync());
    }
}
