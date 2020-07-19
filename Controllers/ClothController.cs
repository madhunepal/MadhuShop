
using MadhuShop.Repository;
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

        public ViewResult viewResult()
        {
            return View(clothrepository.GetAllClothes);
        }
    }
}
