using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
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
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Star> Stars { get; set; }
    }
}