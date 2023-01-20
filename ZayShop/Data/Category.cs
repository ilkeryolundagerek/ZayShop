using System.Collections.Generic;

namespace ZayShop.Data
{
    public class Category : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}