using System.Linq;
using _03_ModelToControllerFromClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_ModelToControllerFromClass.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User user)
        {
            return $"{user.FirstName} {user.Surname} - {user.Age} years old";
        }
    }
}
