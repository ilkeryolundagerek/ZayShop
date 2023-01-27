using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZayShop.Models.Shop;

namespace ZayShop.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index(string category = null, string brand = null, int page = 1)
        {
            return View(new ShopListViewModel(category, brand, page));
        }

        public ActionResult ProductDetail(string product)
        {
            return View();
        }
    }
}