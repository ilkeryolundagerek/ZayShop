using System.Collections.Generic;
using Utilities;
using ZayShop.Services;

namespace ZayShop.Models.Shop
{
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
}