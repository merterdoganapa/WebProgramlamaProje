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

            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Comment = _context.Comment.Find(id).Comment_content;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateComment(string sentence,int id) // Admin veya kelimeyi ekleyen kişi ise kelimeyi güncelleyebilir.
        {

            if (id == null)
            {
                return NotFound();
            }

            Comment comment = await _context.Comment.FindAsync(id);
            comment.Comment_content = sentence;
            comment.date_created = DateTime.Now;
            _context.Comment.Update(comment);
            _context.SaveChangesAsync();
            return RedirectToAction("Detail","Word",new {id = comment.WordId});
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
