using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZayShop.Data
{
    public class Customer : BaseEntity
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Star> Stars { get; set; }
    }
}