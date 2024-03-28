﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolProject1640.Data;
using SchoolProject1640.Models;
using SQLitePCL;
using System.Diagnostics;

namespace SchoolProject1640.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        IWebHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
            _environment = environment;
        }
        public async Task<string> GetFaculty()
        {
            ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
            var getFaculty = await _context.Faculty.FirstOrDefaultAsync(m => m.Id == author.FacultyId);

            if (getFaculty != null)
            {
                return getFaculty.Name; 
            }
            else
            {
                return ""; 
            }
        }
        [Authorize(Roles = "Administrator,Guest,Student,Coordinator,Manager")]
        public async Task<IActionResult> IndexAsync()
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
            var roles = await _userManager.GetRolesAsync(author);
            foreach (var role in roles)
            {
                switch (role)
                {
                    case "Student":
                        // Handle the role Student
                        ViewBag.listArt = _context.Article.Where(m => m.AccountId == author.Id && m.State == 1).ToList();
                        break;
                    case "Guest":
                        // Handle the role Guest
                        break;
                    case "Manager":
                        // Handle the role Manager
                        break;
                    case "Administrator":
                        // Handle the role Administrator
                        ViewBag.listArt = _context.Article.Where(m => m.State == 1).ToList();
                        break;
                    case "Coordinator":
                        // Handle the role Coordinator
                        break;
                    default:
                        // Handle any other roles if needed
                        break;
                }
            }

            //ViewBag.listArt = _context.Article.ToList();

            ViewBag.listNameUSer = _context.User.ToList();
            ViewBag.idUser = author.Id;
            return _context.Contribution != null ?
                        View(await _context.Contribution.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Contribution'  is null.");
            //return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
