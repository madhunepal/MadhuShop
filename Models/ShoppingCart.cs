using MadhuShop.DataLayer;
using MadhuShop.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext dbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };
        }

        public void AddToCart(Cloth cloth, int amount)
        {
            var shoppingCartItem = dbContext.ShoppingCartItems.SingleOrDefault
                (c => c.Cloth.ClothId == cloth.ClothId && c.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Cloth = cloth,
                    Amount = amount
                };
                dbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            dbContext.SaveChanges();
        }

        public int RemoveFromCart(Cloth cloth)
        {
            var shoppingCartItem = dbContext.ShoppingCartItems.SingleOrDefault
               (c => c.Cloth.ClothId == cloth.ClothId && c.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    dbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }

            }
            dbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(c => c.Cloth).ToList());
        }
        public void ClearCart()
        {
            var cartItems = dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            dbContext.ShoppingCartItems.RemoveRange(cartItems);
            dbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Cloth.Price * c.Amount).Sum();

            return (decimal)total;
        }
    }
}
