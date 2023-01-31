using System.Collections.Generic;

namespace ZayShop.Models.Shop
{
    public class SideMenuItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public IEnumerable<SideMenuItem> Items { get; set; }
        public SideMenuItem()
        {
            Items = new HashSet<SideMenuItem>();
        }
    }
}