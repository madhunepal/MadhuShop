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
    public class ShoppingCartController
    {
        private readonly IClothrepository _clothrepository;

        private readonly ICategoryRepository _categoryRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IClothrepository cloth, ICategoryRepository category, ShoppingCart shoppingCart )
            {
                _clothrepository = cloth;
                _categoryRepository = category;
            _shoppingCart = shoppingCart;

            }

        //public ViewResult Index()
        //{
        //    _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

        //    var shoppingCartViewModel = new ShoppingCartViewModel
        //    {
        //        ShoppingCart = _shoppingCart,
        //        ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
        //    };

        //    return View(shoppingCartViewModel);
        //}

        //public RedirectToActionResult AddToShoppingCart(int clothId)
        //{
        //    var selectedCandy = _clothrepository.GetAllClothes.FirstOrDefault(c => c.ClothId == clothId);

        //    if (selectedCandy != null)
        //    {
        //        _shoppingCart.AddToCart(selectedCandy, 1);
        //    }

        //    return RedirectToAction("Index");
        //}

    }
}
