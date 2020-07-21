using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
   public interface IClothrepository
    {
        IEnumerable<Cloth> GetAllClothes { get; }

        IEnumerable<Cloth> GetAllClothOnSale { get; }

        Cloth GetClothById(int clothId);
    }
}
