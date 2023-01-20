using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
    public class ProductImages : BaseEntity
    {
        public string ImageUrl { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}