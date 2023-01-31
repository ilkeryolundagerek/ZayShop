using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Utilities;

namespace ZayShop.Data.Repositories
{
    public class CartItemRepository : GenericRepository<CartItem>
    {
        public CartItemRepository() : base(new ZayContext())
        {
        }
    }
}