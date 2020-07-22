using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MadhuShop.Models;
using MadhuShop.Repository;
using MadhuShop.Viewmodel;

namespace MadhuShop.Controllers
{
    
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;

        private readonly IClothrepository _clothRepository;
        public HomeController(IClothrepository clothrepository)
        {
            _clothRepository = clothrepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                ClothOnSale = _clothRepository.GetAllClothOnSale
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
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
