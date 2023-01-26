using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public override Product ReadFirst(Expression<Func<Product, bool>> predicate = null)
        {
            var data = _set.Include(c => c.Category).Include(b => b.Brand);
            return predicate != null ? data.FirstOrDefault(predicate) : data.FirstOrDefault();
        }

        public override IEnumerable<Product> ReadMany(Expression<Func<Product, bool>> predicate = null)
        {
            var data = _set.Include(c => c.Category).Include(b => b.Brand);
            return predicate != null ? data.Where(predicate) : data;
        }

        public override Product ReadOne(object entityKey)
        {
            var data = _set.Include(c => c.Category).Include(b => b.Brand);
            return data.FirstOrDefault(x => x.Id == (int)entityKey);
        }
    }

    public class BrandRepo : GenericRepository<Brand>
    {
        public BrandRepo() : base(new ZayContext())
        {
        }
    }
}