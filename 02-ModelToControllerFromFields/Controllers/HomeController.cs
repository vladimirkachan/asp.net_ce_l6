using _02_ModelToControllerFromFields.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_ModelToControllerFromFields.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(string firstName, string surname, int age)
        {
            User user = new ()
            {
                FirstName = firstName,
                Surname = surname,
                Age = age
            };

            return $"{user.FirstName} {user.Surname} - {user.Age} years old";
        }
    }
}
