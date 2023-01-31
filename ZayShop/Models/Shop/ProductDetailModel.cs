using System.Collections.Generic;

namespace ZayShop.Models.Shop
{
    public class ProductDetailModel
    {
        public string FeaturedImage { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Category { get; set; }
        public string CategoryUrl { get; set; }
        public string Brand { get; set; }
        public string BrandUrl { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; }
        public decimal DiscountedPrice { get; set; }
        public List<string> Gallery { get; set; }
        public IEnumerable<string> Colors { get; set; }
        public IEnumerable<string> Specifications { get; set; }
        public IEnumerable<string> Sizes { get; set; }
    }
}