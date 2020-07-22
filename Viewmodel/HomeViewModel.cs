using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Viewmodel
{
    public class HomeViewModel
    {
        public IEnumerable<Cloth> ClothOnSale { get; set; }
    }
}
