using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Utilities;

namespace ZayShop.Data.Repositories
{
    public class BrandRepo : GenericRepository<Brand>
    {
        public BrandRepo() : base(new ZayContext())
        {
        }

        public override IEnumerable<Brand> ReadMany(Expression<Func<Brand, bool>> predicate = null)
        {
            var data = _set.Include(p => p.Products);
            return predicate != null ? data.Where(predicate) : data;
        }
    }
}