using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
    public class Color : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}