using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Utilities;

namespace ZayShop.Data.Repositories
{
    public class CategoryRepo : GenericRepository<Category>
    {
        public CategoryRepo() : base(new ZayContext())
        {
        }
    }

    public class ProductRepo : GenericRepository<Product>
    {
        public ProductRepo() : base(new ZayContext())
        {
        }
    }
}