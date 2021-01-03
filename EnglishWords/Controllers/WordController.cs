using EnglishWords.Data;
using EnglishWords.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EnglishWords.Controllers
{
    [Authorize(Roles = "Admin,User")]
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
            string category = word.Category.ToString();
            _context.Word.Remove(word);
            await _context.SaveChangesAsync();


            if (HttpContext.Session.GetString("Role") == "True")
            {
                return RedirectToAction(category,"Category");
            }
            return RedirectToAction("MyWords", "Category");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWord(int id) // Admin veya kelimeyi ekleyen kişi ise kelimeyi güncelleyebilir.
        {

            ViewBag.word = await _context.Word.FindAsync(id);
            
            if(id == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWord(Word word,int id) // Admin veya kelimeyi ekleyen kişi ise kelimeyi güncelleyebilir.
        {
            Word degistirelecekKelime = await _context.Word.FindAsync(id);
            degistirelecekKelime.word_en = word.word_en;
            degistirelecekKelime.word_tr = word.word_tr;
            _context.Word.Update(degistirelecekKelime);
            _context.SaveChanges();
            if (HttpContext.Session.GetString("Role") == "True")
            {
                return RedirectToAction("Dashboard","User");
            }
            return RedirectToAction("MyWords","Category");
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ViewBag.word = _context.Word.Include(x => x.User).Where(x => x.Id == id).FirstOrDefault();
            ViewBag.CommentList = _context.Comment.Include(x => x.User).Where(x => x.WordId == id).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Detail(Comment comment,int id)
        {
            Comment _comment = new Comment();
            _comment.UserId = int.Parse(HttpContext.Session.GetString("UserId"));
            _comment.WordId = id;
            _comment.date_created = DateTime.Now;
            _comment.Comment_content = comment.Comment_content;
            _context.Comment.Add(_comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail");
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
