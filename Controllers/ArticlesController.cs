using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolProject1640.Data;
using SchoolProject1640.Models;

namespace SchoolProject1640.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        IWebHostEnvironment _environment;
        public ArticlesController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
            _environment = environment;
        }
        // GET: Articles
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Index()
        {
            return _context.Article != null ?
                        View(await _context.Article.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Article'  is null.");
        }

        // GET: Articles/Details/5
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Article == null)
            {
                return NotFound();
            }

            var article = _context.Article
                .Where(article => article.Id == id)
                .Join(_context.User,
                        article => article.AccountId,
                        account => account.Id,
                        (article, account) => new { Article = article, Account = account })
                .Join(_context.Contribution,
                        article => article.Article.ContributionId,
                        contribution => contribution.Id,
                        (article, contribution) => new { Article = article, Contribution = contribution })
                .Join(_context.Faculty,
                        article => article.Contribution.Faculty,
                        faculty => faculty.Id,
                        (article, faculty) => new { article.Article, FacultyName = faculty.Name })
                .Select(article => new
                {
                    Article = article.Article.Article,
                    Account = article.Article.Account,
                    FacultyName = article.FacultyName
                })
                .FirstOrDefault();

            if (article == null)
            {
                return NotFound();
            }

            var messages = _context.Message
                .Where(message => message.ArtID == id)
                .Join(_context.User,
                        message => message.AccountID,
                        account => account.Id,
                        (message, account) => new { Message = message, Account = account })
                .Select(message => new
                {
                    Message = message.Message,
                    Account = message.Account
                })
                .ToList();

            var currentUser = await _userManager.GetUserAsync(User);

            //TODO: Check validation for coordinator and manager as well
            //if (currentUser == null || currentUser.Id != article.Account.Id)
            //{
            //    return Unauthorized();
            //}

            ViewBag.Article = article;
            ViewBag.User = currentUser.Id;
            ViewBag.Messages = messages;

            return View();
        }

        // GET: Articles/Create
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.ContributionId = id;
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        [HttpPost]
        public async Task<IActionResult> Create(Article article, int idContri, List<IFormFile> files)
        {
            ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();

            if (files == null || files.Count == 0)
            {
                // Handle this error
                ViewBag.MessErro = "You need to choose at least 1 file to upload.";
               
            }

            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    // Generate a unique identifier
                    var uniqueIdentifier = Guid.NewGuid().ToString();

                    // Construct the new file name with the unique identifier appended
                    var fileName = $"{Path.GetFileNameWithoutExtension(file.FileName)}_{uniqueIdentifier}{Path.GetExtension(file.FileName)}";

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SubmitDocx", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    // Assign the file name and path to the article properties
                    var newArticle = new Article
                    {
                        Title = article.Title,
                        State = article.State,
                        Description = article.Description,
                        ContributionId = idContri,
                        AccountId = author.Id,
                        FileName = fileName,
                        FilePath = path
                    };
                    newArticle.ContributionId = idContri;
                    newArticle.AccountId = author.Id;
                    newArticle.FileName = fileName;
                    newArticle.FilePath = path;
                    _context.Add(newArticle);
                }
            }
            ViewBag.Success = "Upload Sucessfully!.";
            await _context.SaveChangesAsync();
            return RedirectToAction("IndexUser", "Contributions");
            //return View(article);
        }


        // GET: Articles/Edit/5
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Article == null)
            {
                return NotFound();
            }

            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Article article, List<IFormFile> files)
        {
            var tempArti = _context.Article.Where(m => m.Id == article.Id).FirstOrDefault();

            if (id != tempArti.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            // Generate a unique identifier
                            var uniqueIdentifier = Guid.NewGuid().ToString();

                            // Construct the new file name with the unique identifier appended
                            var fileName = $"{Path.GetFileNameWithoutExtension(file.FileName)}_{uniqueIdentifier}{Path.GetExtension(file.FileName)}";

                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SubmitDocx", fileName);

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }

                            if (System.IO.File.Exists(tempArti.FilePath))
                            {
                                System.IO.File.Delete(tempArti.FilePath);
                            }

                            tempArti.FileName = fileName;
                            tempArti.FilePath = path;
                            _context.Update(tempArti);
                        }
                    }
                    tempArti.Title = article.Title;
                    tempArti.Description = article.Description;
                    tempArti.UpdatedAt = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
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
            return View(article);
        }

        // GET: Articles/Delete/5
        [Authorize(Roles = "Administrator,Student,Coordinator,Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Article == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Article == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Article' is null.");
            }

            var article = await _context.Article.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            // Get the path of the file associated with the article
            var filePath = article.FilePath;

            // Remove the article from the context
            _context.Article.Remove(article);

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Delete the associated file from the wwwroot directory
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            return RedirectToAction(nameof(Index));
        }


        private bool ArticleExists(int id)
        {
            return (_context.Article?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public IActionResult DownloadFile(string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SubmitDocx", fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                stream.CopyTo(memory);
            }
            memory.Position = 0;

            return File(memory, "application/octet-stream", Path.GetFileName(filePath));
        }

        public IActionResult ViewFile(string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SubmitDocx", fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            return File(System.IO.File.OpenRead(filePath), "application/pdf", null);
        }
        [HttpPost]
        public async Task<IActionResult> AcceptArt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article tempArt = await _context.Article.FirstOrDefaultAsync(m => m.Id == id);

            if (tempArt == null)
            {
                return NotFound();
            }

            tempArt.State = 1;

            await _context.SaveChangesAsync();

            return RedirectToAction("IndexUser", "Contributions");
        }
        [HttpPost]
        public async Task<IActionResult> RejectArt(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article tempArt = await _context.Article.FirstOrDefaultAsync(m => m.Id == id);

            if (tempArt == null)
            {
                return NotFound();
            }

            tempArt.State = 2;

            await _context.SaveChangesAsync();

            return RedirectToAction("IndexUser", "Contributions");
        }

    }
}
