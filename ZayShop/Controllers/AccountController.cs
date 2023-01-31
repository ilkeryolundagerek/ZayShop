using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZayShop.Models.Account;

namespace ZayShop.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

    }
}