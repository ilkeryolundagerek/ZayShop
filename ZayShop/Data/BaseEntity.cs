using System;
using System.ComponentModel.DataAnnotations;
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
}