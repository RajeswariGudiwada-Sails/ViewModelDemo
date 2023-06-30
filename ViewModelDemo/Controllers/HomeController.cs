using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;

namespace ViewModelDemo.Controllers
{
    public class HomeController : Controller
    {

        private List<Animal> animals = new List<Animal>()
        {
            new Animal{Name ="Monkey"},
            new Animal{Name ="Donkey"},
            new Animal{Name ="Horse"},
            new Animal{Name ="Elephant"},
            new Animal{Name ="Lion"}

        };
        private List<Zoo> zoos = new List<Zoo>()
        {
            new Zoo{City ="London"},
            new Zoo{City ="Paris"},
            new Zoo{City ="New york"},
            new Zoo{City ="USA"},
            new Zoo{City ="UK"},

        };
       

        public IActionResult Index()
        {
            AnimalZooData vm = new AnimalZooData();
            vm.animals = animals;
            vm.zoos = zoos;
            TempData["msg"] = "Animals List";
            ViewBag.lst = "Zoos List";
            return View(vm);
        }

    }
}