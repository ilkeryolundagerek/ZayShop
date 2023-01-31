using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZayShop.Data;
using ZayShop.Data.Repositories;
using ZayShop.Models.Account;

namespace ZayShop.Services
{
    public class AccountServices
    {
        private CustomerRepo _customerRepo;
        public AccountServices()
        {
            _customerRepo = new CustomerRepo();
        }

        public void Register(RegisterViewModel model)
        {
            Customer user = _customerRepo.ReadFirst(x => x.Email.Equals(model.Email));
            if (user == null)
            {
                user = new Customer()
                {
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Middlename = model.Middlename,
                    Lastname = model.Lastname,
                    Password = model.Password,
                    Active = true,
                    Deleted = false,
                    CreateDate = DateTime.Now,
                    Detail = "",
                    Phone = "",
                    Title = ""
                };
                _customerRepo.CreateOne(user);
                _customerRepo.Save();
            }
        }

        public bool Login(LoginViewModel model)
        {
            Customer user = _customerRepo.ReadFirst(x => x.Email.Equals(model.Email));
            if(user != null) {
                if (user.Password.Equals(model.Password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}