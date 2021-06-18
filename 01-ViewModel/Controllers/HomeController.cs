using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_ViewModel.Models;
using _01_ViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _01_ViewModel.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Person> persons = new()
            {
                new() { Id = 1, FirstName = "VovA", LastName = "KachaN", Age = 17 },
                new() { Id = 2, FirstName = "Natasha", LastName = "Malinova", Age = 32 },
                new() { Id = 3, FirstName = "Alex", LastName = "Shevchuk", Age = 18 }
            };

            List<Company> companies = new()
            {
                new() { Id = 1, Name = "Info Sapiens", City = "Kiev" },
                new() { Id = 2, Name = "BSA", City = "Lviv" }
            };

            var works = new WorksViewModel { Persons = persons, Companies = companies };

            return View(works);
        }
    }
}
