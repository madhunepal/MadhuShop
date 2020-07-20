
using MadhuShop.Repository;
using MadhuShop.Viewmodel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Controllers
{
    public class ClothController : Controller
    {
        private readonly IClothrepository clothrepository;

        private readonly ICategoryRepository categoryRepository;

        public ClothController( ICategoryRepository category, IClothrepository cloth)
        {
            categoryRepository = category;
            clothrepository = cloth;
        }

        public IActionResult viewResult()
        {
            //return View(clothrepository.GetAllClothes);
            var clothlistView = new ClothListViewModel();
            //clothlistView.Clothes = clothrepository.GetAllClothes;
            clothlistView.CurrentCategory = "BestSeller";
            return View(clothlistView);
        }
    }
}
