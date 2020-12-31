using Microsoft.AspNetCore.Authorization;
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

namespace MyEnglishWords.Controllers
{
    public class CategoryController:Controller
    {

        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationDbContext _context;
        

        public CategoryController(ILogger<CategoryController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[Authorize]
        public IActionResult Home()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x=> x.Category == "Home").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }

        public IActionResult Food()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x => x.Category == "Food").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }

        public IActionResult Verb()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x => x.Category == "Verb").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }

        public IActionResult Technology()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x => x.Category == "Technology").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }


        public IActionResult Transportation()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x => x.Category == "Transportation").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }

        public IActionResult General()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.WordList = _context.Word.Where(x => x.Category == "General").ToList();
            ViewBag.UserList = _context.User.ToList();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
