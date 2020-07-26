using MadhuShop.Models;
using MadhuShop.Repository;
using MadhuShop.Viewmodel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IClothrepository _clothRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IClothrepository clothRepository, ShoppingCart shoppingCart)
        {
            _clothRepository = clothRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int ClothId)
        {
            var selectedCloth = _clothRepository.GetAllClothes.FirstOrDefault(c => c.ClothId == ClothId);

            if (selectedCloth != null)
            {
                _shoppingCart.AddToCart(selectedCloth, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int clothId)
        {
            var selectedCloth = _clothRepository.GetAllClothes.FirstOrDefault(c => c.ClothId == clothId);

            if (selectedCloth != null)
            {
                _shoppingCart.RemoveFromCart(selectedCloth);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
