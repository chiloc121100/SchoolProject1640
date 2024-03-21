using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolProject1640.Data;
using SchoolProject1640.Models;

namespace SchoolProject1640.Controllers
{
    public class ContributionsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ContributionsController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }
        // GET: Contributions
        public async Task<IActionResult> Index()
        {
              return _context.Contribution != null ? 
                          View(await _context.Contribution.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
        }
        public async Task<IActionResult> IndexUser()
        {
            ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
            var tempListFaculty = await _context.Faculty.FirstOrDefaultAsync(m => m.Id == author.FacultyId);
            if (tempListFaculty != null)
            {
                ViewBag.getFacultyOfStudent = tempListFaculty.Name;
            } 
            else
            {
                ViewBag.getFacultyOfStudent = "";
            }
            return _context.Contribution != null ?
                        View(await _context.Contribution.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
        }
        // GET: Contributions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contribution == null)
            {
                return NotFound();
            }

            var contribution = await _context.Contribution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contribution == null)
            {
                return NotFound();
            }

            return View(contribution);
        }

        // GET: Contributions/Create
        public IActionResult Create()
        {
            var listFaculty = _context.Faculty.ToList();
            ViewBag.ListFaculty = listFaculty;
            return View();
        }

        // POST: Contributions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Faculty,AcademicYear,StartDate,ClosureDate,FinalClosureDate,CreatedAt,UpdatedAt")] Contribution contribution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contribution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contribution);
        }

        // GET: Contributions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contribution == null)
            {
                return NotFound();
            }

            var contribution = await _context.Contribution.FindAsync(id);
            if (contribution == null)
            {
                return NotFound();
            }
            return View(contribution);
        }

        // POST: Contributions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Faculty,AcademicYear,StartDate,ClosureDate,FinalClosureDate,CreatedAt,UpdatedAt")] Contribution contribution)
        {
            if (id != contribution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contribution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContributionExists(contribution.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contribution);
        }

        // GET: Contributions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contribution == null)
            {
                return NotFound();
            }

            var contribution = await _context.Contribution
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contribution == null)
            {
                return NotFound();
            }

            return View(contribution);
        }

        // POST: Contributions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contribution == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
            }
            var contribution = await _context.Contribution.FindAsync(id);
            if (contribution != null)
            {
                _context.Contribution.Remove(contribution);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContributionExists(int id)
        {
          return (_context.Contribution?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
