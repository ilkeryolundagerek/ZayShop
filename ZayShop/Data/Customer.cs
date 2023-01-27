using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    public class Cart : BaseEntity
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }

    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }

    public class Like
    {
        [Key, Column(Order = 0), ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Key, Column(Order = 1), ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

    public class Star
    {
        [Key, Column(Order = 0), ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Key, Column(Order = 1), ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int StarCount { get; set; }
    }
}