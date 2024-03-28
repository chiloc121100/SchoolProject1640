using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolProject1640.Data;
using SchoolProject1640.Models;
using Microsoft.AspNetCore.Authorization;


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
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Index()
        {
              return _context.Contribution != null ? 
                          View(await _context.Contribution.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
        }
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> IndexUser()
        {
            ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
            var tempListFaculty = await _context.Faculty.FirstOrDefaultAsync(m => m.Id == author.FacultyId);
            if (tempListFaculty != null)
            {
                ViewBag.getFacultyOfStudent = tempListFaculty.Id;
            } 
            else
            {
                ViewBag.getFacultyOfStudent = "";
            }
            //ViewBag.listArt = _context.Article.Where(m => m.AccountId == author.Id).ToList();
            ViewBag.listArt = _context.Article.ToList();
            ViewBag.idUser = author.Id;
            return _context.Contribution != null ?
                        View(await _context.Contribution.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
        }
        // GET: Contributions/Details/5
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
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
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
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
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Create([Bind("Id,Title,Faculty,AcademicYear,StartDate,ClosureDate,FinalClosureDate,CreatedAt,UpdatedAt")] Contribution contribution)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
                var listUserNotification = _context.User.Where(m => m.FacultyId == contribution.Faculty).ToList();
                foreach(var user in listUserNotification)
                {
                    var notification = new SchoolProject1640.Models.Notification();
                    notification.SendBy = author.Email;
                    notification.FacultyId = contribution.Faculty;
                    notification.isRead = false;
                    notification.UserID = user.Id;
                    notification.RoleId = "2";
                    notification.Message = $"{contribution.Title} has been created please join this.";
                    _context.Add(notification);
                    SendGmailAsync(author.Email, user.Email);
                }
                _context.Add(contribution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contribution);
        }
        public async Task SendGmailAsync(string? user, string? userrec)
        {
            if (user == null)
            { return; }
            try
            {
                // Create a new MailMessage
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress("duongchilocmail@gmail.com");
                    message.To.Add(userrec);
                    message.Subject = "New Contribution";
                    message.Body = $"{user}: has been created please join this";

                    // Create a new SMTP client
                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential("duongchilocmail@gmail.com", "sallqsnernrfmxkw");

                        // Send the email
                        await smtpClient.SendMailAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // GET: Contributions/Update/5
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
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

        // POST: Contributions/Update/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Update(int id, [Bind("Id,Title,Faculty,AcademicYear,StartDate,ClosureDate,FinalClosureDate,CreatedAt,UpdatedAt")] Contribution contribution)
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
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
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
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
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

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult SearchContribution(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var contributions = _context.Contribution
                    .Join(_context.Faculty,
                        contribution => contribution.Faculty,
                        faculty => faculty.Id,
                        (contribution, faculty) => new { Contribution = contribution, FacultyName = faculty.Name })
                    .Where(contribution => contribution.Contribution.Title.Contains(title))
                    .OrderByDescending(contribution => contribution.Contribution.Title)
                    .Select(contribution => new
                    {
                        Contribution = contribution.Contribution,
                        FacultyName = contribution.FacultyName,
                    })
                    .ToList();

                return Json(contributions);
            }
            else
            {
                var contributions = _context.Contribution
                    .Join(_context.Faculty,
                        contribution => contribution.Faculty,
                        faculty => faculty.Id,
                        (contribution, faculty) => new { Contribution = contribution, FacultyName = faculty.Name })
                    .OrderByDescending(contribution => contribution.Contribution.Title)
                    .Select(contribution => new
                    {
                        Contribution = contribution.Contribution,
                        FacultyName = contribution.FacultyName,
                    })
                    .ToList();

                return Json(contributions);
            }
        }

        private bool ContributionExists(int id)
        {
          return (_context.Contribution?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
