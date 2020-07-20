using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Viewmodel
{
    public class ClothListViewModel
    {
        public IEnumerable<Cloth> Clothes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
