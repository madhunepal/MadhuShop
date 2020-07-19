using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
   public interface IClothrepository
    {
        IEnumerable<IClothrepository> GetAllClothes { get; }

        IEnumerable<IClothrepository> GetAllClothOnSale { get; }

        IClothrepository GetClothById(int clothId);
    }
}
