using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment5a.Models;

namespace Assessment5a.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            if (ModelState.IsValid && account.password == "open sesame")
            {
                return View("Welcome", account);
            }
            return View("WrongPassword");
        }


        public IActionResult Welcome(Account account)
        {
            ViewBag.Name = account.name.ToUpper();
            ViewBag.Length = account.name.Length;
            return View(account);
        }

        public IActionResult WrongPassword()
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
