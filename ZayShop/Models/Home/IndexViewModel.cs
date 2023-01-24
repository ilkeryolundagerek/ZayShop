using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZayShop.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<SlideViewModel> Slider { get; set; }
        public IEnumerable<CategoryOfTheMoonViewModel> CategoriesOfTheMoon { get; set; }
        public IEnumerable<FeaturedProductViewModel> FeaturedProducts { get; set; }
        public IndexViewModel()
        {
            Slider = new HashSet<SlideViewModel>();
            CategoriesOfTheMoon = new HashSet<CategoryOfTheMoonViewModel>();
            FeaturedProducts = new HashSet<FeaturedProductViewModel>();
        }
    }

    public class SlideViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ButtonUrl { get; set; }
        public string ButtonText { get; set; }
    }

    public class CategoryOfTheMoonViewModel
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }

    public class FeaturedProductViewModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ImagePath { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
    }
}