using System.Collections.Generic;

namespace ZayShop.Data
{
    public class Brand : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public Brand()
        {
            Products = new HashSet<Product>();
        }
    }
}