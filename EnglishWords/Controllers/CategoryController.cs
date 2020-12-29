using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnglishWords.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyEnglishWords.Controllers
{
    public class CategoryController:Controller
    {

        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }
        [Authorize]
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Verb()
        {
            return View();
        }

        public IActionResult Technology()
        {
            return View();
        }


        public IActionResult Transportation()
        {
            return View();
        }

        public IActionResult General()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
