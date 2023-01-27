using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;
using ZayShop.Data;
using ZayShop.Services;

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

    public class SideMenuItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public IEnumerable<SideMenuItem> Items { get; set; }
        public SideMenuItem()
        {
            Items = new HashSet<SideMenuItem>();
        }
    }

    public class ShopListViewModel
    {
        public IEnumerable<SideMenuItem> SideMenuBrands { get; set; }
        public IEnumerable<SideMenuItem> SideMenuCategories { get; set; }
        public Pagination<ProductListItem> ProductList { get; set; }
        public string CategoryFilter { get; set; }
        public string BrandFilter { get; set; }
        public ShopListViewModel(string category, string brand, int page)
        {
            ShopService service = new ShopService();
            SideMenuBrands = service.GetBrands();
            SideMenuCategories = service.GetCategories();
            ProductList = new Pagination<ProductListItem>(service.GetProducts(category, brand), 12, page, 2);
            CategoryFilter = category;
            BrandFilter = brand;
        }
    }

    public class ShopDetailViewModel
    {
        public ProductDetailModel Product { get; set; }
        //public IEnumerable<ProductListItem> RelatedProducts { get; set; }
        public ShopDetailViewModel(string product)
        {
            ShopService service = new ShopService();
            Product = service.GetProduct(product);
        }
    }

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