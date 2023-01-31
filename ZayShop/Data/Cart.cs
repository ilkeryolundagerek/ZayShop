using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZayShop.Data
{
    public class Cart : BaseEntity
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string Status { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}