using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZayShop.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
    }

    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }
        public decimal CampaignRate { get; set; }
        public decimal TaxRate { get; set; }
        public string FeaturedImage { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<ProductSpecification> Specifications { get; set; }
        public virtual ICollection<ProductSize> Sizes { get; set; }
        public virtual ICollection<ProductImages> Images { get; set; }
    }

    public class Category : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
    public class Brand : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public Brand()
        {
            Products = new HashSet<Product>();
        }
    }
    public class Color : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

    public class ProductSpecification : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

    public class ProductSize : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }

    public class ProductImages : BaseEntity {
        public string ImageUrl { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}