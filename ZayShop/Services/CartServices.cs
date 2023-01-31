using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZayShop.Data;
using ZayShop.Data.Repositories;

namespace ZayShop.Services
{
    public class CartServices
    {
        private CartRepository _cartRepository;
        private CartItemRepository _cartItemRepository;
        public CartServices()
        {
            _cartRepository = new CartRepository();
            _cartItemRepository = new CartItemRepository();
        }

        public void AddToCart(int productId, int quantity)
        {

        }

        public void RemoveFromCart(int productId, int quantity)
        {

        }

        public void CompleteShping()
        {

        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return null;
        }
    }
}