using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
    public class ClothRepository : IClothrepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
      //public  IEnumerable<Cloth> GetAllClothes => new List<Cloth>
      //{ 
      //  new Cloth {ClothId = 1, Name="Addidas", Price = 45.99, Description="new nylon pant",
      //      Category = _categoryRepository.GetAllCategories.ToList()[0], ImageUrl="www.madhunepal.com", IsOnStock = true, IsOnSale= false, ImageThumbNailUrl ="#" }
        
      //  };

      public IEnumerable<Cloth> GetAllClothOnSale => throw new NotImplementedException();

        IEnumerable<IClothrepository> IClothrepository.GetAllClothes => throw new NotImplementedException();

        IEnumerable<IClothrepository> IClothrepository.GetAllClothOnSale => throw new NotImplementedException();

        //public Cloth GetClothById(int clothId)
        //{
        //    return GetAllClothes.FirstOrDefault(c => c.ClothId == clothId);
        //}

        IClothrepository IClothrepository.GetClothById(int clothId)
        {
            throw new NotImplementedException();
        }
    }
}
