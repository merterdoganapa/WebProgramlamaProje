using EnglishWords.Data;
using EnglishWords.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishWords.Controllers
{
    public class WordController:Controller
    {

        private readonly ILogger<WordController> _logger;
        private readonly ApplicationDbContext _context;

        public WordController(ILogger<WordController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult AddWord()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                ViewBag.Message = "Kelime eklemeniz için öncelikle giriş yapmalısınız .";
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddWord(Word word,int id)
        {
            Word eklenecekKelime = new Word();
            eklenecekKelime.word_en = word.word_en;
            eklenecekKelime.word_tr = word.word_tr;
            eklenecekKelime.UserId = int.Parse(HttpContext.Session.GetString("UserId"));
            eklenecekKelime.User = _context.User.Find(eklenecekKelime.UserId);
            eklenecekKelime.Category = degeriDondur(id);
            eklenecekKelime.date_created = DateTime.Now;
            _context.Word.Add(eklenecekKelime);
            _context.SaveChanges();
            return RedirectToAction(eklenecekKelime.Category.ToString(), "Category");
        }

        public async Task<IActionResult> DeleteWord(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var word = await _context.Word.FindAsync(id);
            _context.Word.Remove(word);
            await _context.SaveChangesAsync();
            if (HttpContext.Session.GetString("Role") == "True")
            {
                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("MyWords", "Category");
        }


        public Category degeriDondur(int index)
        {
            foreach (var value in Enum.GetValues(typeof(Category)))
            {
                if ((int)value == index)
                {
                    return (Category)value;
                }
            }
            return Category.Home;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
