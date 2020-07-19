using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories =>  new List<Category>
        {

            new Category { CategoryId = 1, CategoryName = "Pant", CategoryDescription = "Belly Bottom pant for male" },


            new Category { CategoryId = 2, CategoryName = "Shirt", CategoryDescription = "Half sleev shirt for male" },

             new Category { CategoryId = 3, CategoryName = "Saree", CategoryDescription = "Banarasi Saree for female" },

            //IEnumerable<ICategoryRepository> ICategoryRepository.GetAllCategories => throw new NotImplementedException();
        };

        IEnumerable<ICategoryRepository> ICategoryRepository.GetAllCategories => throw new NotImplementedException();

        // IEnumerable<ICategoryRepository> ICategoryRepository.GetAllCategories => throw new NotImplementedException();
    }
}
