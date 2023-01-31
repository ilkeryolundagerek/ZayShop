using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZayShop.Services;

namespace ZayShop.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<SlideViewModel> Slider { get; set; }
        public IEnumerable<CategoryOfTheMoonViewModel> CategoriesOfTheMoon { get; set; }
        public IEnumerable<FeaturedProductViewModel> FeaturedProducts { get; set; }

        public IndexViewModel()
        {
            HomeService service = new HomeService();
            Slider = new HashSet<SlideViewModel>();
            CategoriesOfTheMoon = service.GetCategoryOfTheMoons();
            FeaturedProducts = service.GetFeaturedProducts();
        }
    }
}