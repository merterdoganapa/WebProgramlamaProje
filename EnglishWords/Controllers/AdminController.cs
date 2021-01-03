using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnglishWords.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EnglishWords.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace EnglishWords.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Dashboard()
        {
            ViewBag.UserList = _context.User.ToList();

            ViewBag.WordList = _context.Word.ToList();

            return View();
        }

        public IActionResult DeleteUser(int id)
        {
            User user = _context.User.Find(id);
            _context.User.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}
