using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
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
}