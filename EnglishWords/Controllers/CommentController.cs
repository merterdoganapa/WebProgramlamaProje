using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnglishWords.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using EnglishWords.Data;

namespace EnglishWords.Controllers
{
    public class CommentController : Controller
    {
        private readonly ILogger<CommentController> _logger;
        private readonly ApplicationDbContext _context;

        public CommentController(ILogger<CommentController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> DeleteComment(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comment = await _context.Comment.FindAsync(id);
            int wordId = comment.WordId;
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Detail", "Word",new { id = wordId});
        }

        [HttpGet]
        public async Task<IActionResult> UpdateComment(int id) // Admin veya kelimeyi ekleyen kişi ise kelimeyi güncelleyebilir.
        {

            var word = await _context.Word.FindAsync(id);
            var user = await _context.User.FindAsync(word.UserId);

            if ((id == null) && (HttpContext.Session.GetString("Username") == user.Username || user.is_superuser == true))
            {
                return NotFound();
            }
            ViewBag.word = word;
            ViewBag.Username = HttpContext.Session.GetString("Username");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateComment(Word word, int id) // Admin veya kelimeyi ekleyen kişi ise kelimeyi güncelleyebilir.
        {
            Word degistirelecekKelime = await _context.Word.FindAsync(id);
            degistirelecekKelime.word_en = word.word_en;
            degistirelecekKelime.word_tr = word.word_tr;
            _context.Word.Update(degistirelecekKelime);
            _context.SaveChanges();
            if (HttpContext.Session.GetString("Role") == "True")
            {
                return RedirectToAction("Dashboard", "User");
            }
            return RedirectToAction("MyWords", "Category");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
