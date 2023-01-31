using ZayShop.Services;

namespace ZayShop.Models.Shop
{
    public class ShopDetailViewModel
    {
        public ProductDetailModel Product { get; set; }
        //public IEnumerable<ProductListItem> RelatedProducts { get; set; }
        public ShopDetailViewModel(string product)
        {
            ShopService service = new ShopService();
            Product = service.GetProduct(product);
        }
    }
}