
using MadhuShop.Models;
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
        private readonly IClothrepository _clothrepository;

        private readonly ICategoryRepository _categoryRepository;

        public ClothController(IClothrepository cloth , ICategoryRepository category)
        {
            _clothrepository = cloth;
            _categoryRepository = category;
           
        }

        public IActionResult viewResult(string category)
        {
            IEnumerable<Cloth> cloths;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cloths =  _clothrepository.GetAllClothes.OrderByDescending(c=>c.ClothId); // _candyRepository.GetAllCandy.OrderBy(c => c.CandyId);
                currentCategory = "All Clothes";
            }
            else
            {
                cloths = _clothrepository.GetAllClothes.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ClothListViewModel
            {
                Clothes = cloths,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var cloth = _clothrepository.GetClothById(id);
            if (cloth == null)
                return NotFound();

            return View(cloth);
        }
    }
}
