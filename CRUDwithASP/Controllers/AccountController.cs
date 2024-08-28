using CRUDwithASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithASP.Controllers
{
    public class AccountController : Controller
    {
        //Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {

            if (login.UserEmail == "nour@gmail.com" && login.UserPassword == "123") 
            {
                return RedirectToAction("GetAllCourses", "Course");
            }
            return View(login);
        }
    }
}
