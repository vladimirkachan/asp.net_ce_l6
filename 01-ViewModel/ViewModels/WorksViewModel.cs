using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_ViewModel.Models;

namespace _01_ViewModel.ViewModels
{
    public class WorksViewModel
    {
        public IEnumerable<Person> Persons {get; set;}
        public IEnumerable<Company> Companies {get; set;}
    }
}
