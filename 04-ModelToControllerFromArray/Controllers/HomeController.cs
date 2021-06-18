using System.Linq;
using _03_ModelToControllerFromClass.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_ModelToControllerFromArray.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User[] users)
        {
            return users.Aggregate("", (current, user) => current + $"{user.FirstName} {user.Surname} - {user.Age} years old\n");
        }

    }
}
