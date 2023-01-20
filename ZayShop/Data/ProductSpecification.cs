using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
    public class ProductSpecification : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}