using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;
using ZayShop.Data;
using ZayShop.Data.Repositories;
using ZayShop.Models.Home;

namespace ZayShop.Services
{
    public class HomeService
    {
        private CategoryRepo _categoryRepo;
        private ProductRepo _productRepo;

        public HomeService()
        {
            _categoryRepo = new CategoryRepo();
            _productRepo = new ProductRepo();
        }

        public IEnumerable<CategoryOfTheMoonViewModel> GetCategoryOfTheMoons()
        {
            return from c in _categoryRepo.ReadMany().Take(3)
                   select new CategoryOfTheMoonViewModel
                   {
                       Title = c.Title,
                       Url = c.Title,
                       ImagePath = "https://picsum.photos/400"
                   };
        }

        public IEnumerable<FeaturedProductViewModel> GetFeaturedProducts()
        {
            return from p in _productRepo.ReadMany().Take(3)
                   select new FeaturedProductViewModel
                   {
                       Name = p.Title,
                       ShortDescription = p.Detail,
                       Price = p.Price,
                       ImagePath = p.FeaturedImage,
                       Url = p.Title
                   };
        }
    }
}