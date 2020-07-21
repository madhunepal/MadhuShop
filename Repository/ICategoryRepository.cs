using MadhuShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }

}
