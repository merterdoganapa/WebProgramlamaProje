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
    public class UserController:Controller
    {


        private readonly ILogger<UserController> _logger;
        private readonly ApplicationDbContext _context;

        public UserController(ILogger<UserController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            User LoggedInUser = _context.User.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault();

            if (LoggedInUser == null)
            {
                ViewBag.Message = " Kullanıcı adıyla parola eşleşmemektedir .";
                return View();
            }

            HttpContext.Session.SetString("Username", LoggedInUser.Username);
            HttpContext.Session.SetString("Role", Convert.ToString(LoggedInUser.is_superuser));

            return RedirectToAction("Dashboard");
        }

        public string GetStringUsername()
        {
            return HttpContext.Session.GetString("Username");
        }

        public string GetStringRole()
        {
            return HttpContext.Session.GetString("Role");
        }

        public IActionResult Dashboard()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login");
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid) {

                var controlUser = _context.User.Where(x => x.Username == user.Username || x.Mail == user.Mail).FirstOrDefault();

                if (controlUser == null)
                {
                    _context.User.Add(user);
                    _context.SaveChanges();
                    return RedirectToAction("Login");
                }

                else
                {
                    ViewBag.Message = "Geçersiz kullanıcı adı veya mail";
                    return View();
                }
            }
            
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
