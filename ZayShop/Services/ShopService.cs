using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using Utilities;
using ZayShop.Data;
using ZayShop.Data.Repositories;
using ZayShop.Models.Shop;

namespace ZayShop.Services
{

    public class ShopService
    {
        private CategoryRepo _categoryRepo;
        private BrandRepo _brandRepo;
        private ProductRepo _productRepo;

        public ShopService()
        {
            _categoryRepo = new CategoryRepo();
            _productRepo = new ProductRepo();
            _brandRepo = new BrandRepo();
        }

        public IEnumerable<SideMenuItem> GetBrands()
        {
            return from brand in _brandRepo.ReadMany(x => x.Active && !x.Deleted)
                   select new SideMenuItem { Title = brand.Title, Url = brand.Title.ToUrl() };
        }

        public IEnumerable<SideMenuItem> GetCategories()
        {
            return from category in _categoryRepo.ReadMany(x => x.Active && !x.Deleted)
                   select new SideMenuItem { Title = category.Title, Url = category.Title.ToUrl() };
        }

        public IEnumerable<ProductListItem> GetProducts(string category = null, string brand = null)
        {
            if (!string.IsNullOrEmpty(category))
            {
                return from product in _productRepo.ReadMany(x => x.Active && !x.Deleted)
                       where product.Category.Title.ToUrl() == category
                       select new ProductListItem
                       {
                           Price = product.Price,
                           FeaturedImage = product.FeaturedImage,
                           Brand = product.Brand.Title,
                           BrandUrl = product.Brand.Title.ToUrl(),
                           Category = product.Category.Title,
                           CategoryUrl = product.Category.Title.ToUrl(),
                           Title = product.Title,
                           DiscountedPrice = product.IsInCampaign ? (product.Price * ((100 - product.CampaignRate) / 100m)) : 0,
                           DetailUrl = product.Title.ToUrl()
                       };
            }
            else if (!string.IsNullOrEmpty(brand))
            {
                return from product in _productRepo.ReadMany(x => x.Active && !x.Deleted)
                       where product.Brand.Title.ToUrl() == brand
                       select new ProductListItem
                       {
                           Price = product.Price,
                           FeaturedImage = product.FeaturedImage,
                           Brand = product.Brand.Title,
                           BrandUrl = product.Brand.Title.ToUrl(),
                           Category = product.Category.Title,
                           CategoryUrl = product.Category.Title.ToUrl(),
                           Title = product.Title,
                           DiscountedPrice = product.IsInCampaign ? (product.Price * ((100 - product.CampaignRate) / 100m)) : 0,
                           DetailUrl = product.Title.ToUrl()
                       };
            }
            else
            {
                return from product in _productRepo.ReadMany(x => x.Active && !x.Deleted)
                       select new ProductListItem
                       {
                           Price = product.Price,
                           FeaturedImage = product.FeaturedImage,
                           Brand = product.Brand.Title,
                           BrandUrl = product.Brand.Title.ToUrl(),
                           Category = product.Category.Title,
                           CategoryUrl = product.Category.Title.ToUrl(),
                           Title = product.Title,
                           DiscountedPrice = product.IsInCampaign ? (product.Price * ((100 - product.CampaignRate) / 100m)) : 0,
                           DetailUrl = product.Title.ToUrl()
                       };
            }
        }
    }
}