
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadhuShop.Models;
using MadhuShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MadhuShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IorderRepository _orderrepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController( IorderRepository iorderRepository, ShoppingCart shoppingCart )
        {
            _orderrepository = iorderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                _orderrepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for shoping with us. Happy Wearing and See you soon";
            return View();
        }

    }
}
