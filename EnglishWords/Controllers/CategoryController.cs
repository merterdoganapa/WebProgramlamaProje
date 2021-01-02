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
using Microsoft.EntityFrameworkCore;

namespace MyEnglishWords.Controllers
{

    [Authorize(Roles = "Admin,User")]
    public class CategoryController:Controller
    {

        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationDbContext _context;
        

        public CategoryController(ILogger<CategoryController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult MyWords()
        {
            ViewBag.WordList = _context.Word.Where(x => x.UserId == int.Parse(HttpContext.Session.GetString("UserId"))).ToList();
            return View();
        }
        public IActionResult Home()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.Home).ToList();
            return View(wordListesi);
        }
        public IActionResult Food()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.Food).ToList();
            return View(wordListesi);
        }
        
        public IActionResult Verb()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.Verb).ToList();
            return View(wordListesi);
        }

        public IActionResult Technology()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.Technology).ToList();
            return View(wordListesi);
        }


        public IActionResult Transportation()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.Transportation).ToList();
            return View(wordListesi);
        }

        public IActionResult General()
        {
            var wordListesi = _context.Word.Include(x => x.User).Where(c => c.Category == Category.General).ToList();
            return View(wordListesi);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
