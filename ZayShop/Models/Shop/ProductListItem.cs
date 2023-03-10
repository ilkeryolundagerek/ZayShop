using System;
using System.Linq;
using System.Web;
using ZayShop.Data;

namespace ZayShop.Models.Shop
{
    public class ProductListItem
    {
        public string FeaturedImage { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string CategoryUrl { get; set; }
        public string Brand { get; set; }
        public string BrandUrl { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public string DetailUrl { get; set; }
    }
}