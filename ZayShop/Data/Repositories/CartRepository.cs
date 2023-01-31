using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;

namespace ZayShop.Data.Repositories
{
    public class CartRepository : GenericRepository<Cart>
    {
        public CartRepository() : base(new ZayContext())
        {
        }
    }
}