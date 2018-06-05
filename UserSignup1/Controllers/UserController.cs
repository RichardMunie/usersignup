using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup1.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if((user.Password != null && verify != null) && verify == user.Password)
            {

                ViewBag.message = "Welcome, " + user.Username;
                return View("Index");
            }
 
            ViewBag.message = "Passwords do not match";
            user.Password = string.Empty;
            ViewBag.user = user;
            return View();
            
        }
    }
}
