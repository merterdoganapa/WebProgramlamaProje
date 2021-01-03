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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

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
                ViewBag.Message = " Bilgilerinizi kontrol ediniz .";
                return View();
            }

            HttpContext.Session.SetString("Username", LoggedInUser.Username);
            HttpContext.Session.SetString("UserId", Convert.ToString(LoggedInUser.Id));
            HttpContext.Session.SetString("Role", Convert.ToString(LoggedInUser.is_superuser));


            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            if (LoggedInUser.is_superuser == true)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,LoggedInUser.Username),
                    new Claim(ClaimTypes.Role,"Admin"),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (LoggedInUser.is_superuser == false)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,LoggedInUser.Username),
                    new Claim(ClaimTypes.Role,"User"),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);
                return RedirectToAction("Index","Home");
                
            }

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

        public async Task<IActionResult> Logout()
        {

            if (HttpContext != null)
            {
                if (HttpContext.Request.Cookies.Count > 0)
                {
                    var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.Contains(".AspNetCore.") ||
                    c.Key.Contains("Microsoft.Authentication"));
                    foreach (var cookie in siteCookies)
                    {
                        Response.Cookies.Delete(cookie.Key);
                    }
                }

            }
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login","User");
        }


        public string GetStringUsername()
        {
            return HttpContext.Session.GetString("Username");
        }

        public string GetStringRole()
        {
            return HttpContext.Session.GetString("Role");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
