using MadhuShop.DataLayer;
using MadhuShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
    public class ClothRepository : IClothrepository
    {
        private readonly ApplicationDbContext db ;
        public ClothRepository( ApplicationDbContext appDbContext)
        {
            db = appDbContext;
        }

        public IEnumerable<Cloth> GetAllClothes
        {
            get
            {
                return db.Clothes.Include(c => c.Category);
            }
        }
      public IEnumerable<Cloth> GetAllClothOnSale
        {
            get
            {
                return db.Clothes.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

       // IEnumerable<IClothrepository> IClothrepository.GetAllClothes => throw new NotImplementedException();

        //IEnumerable<IClothrepository> IClothrepository.GetAllClothOnSale => throw new NotImplementedException();

        //public Cloth GetClothById(int clothId)
        //{
        //    return GetAllClothes.FirstOrDefault(c => c.ClothId == clothId);
        //}

        public Cloth GetClothById(int clothId)
        {
           return db.Clothes.FirstOrDefault(c=> c.ClothId == clothId);
        }
    }
}
