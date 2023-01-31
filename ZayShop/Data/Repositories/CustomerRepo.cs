using Utilities;

namespace ZayShop.Data.Repositories
{
    public class CustomerRepo : GenericRepository<Customer>
    {
        public CustomerRepo() : base(new ZayContext())
        {
        }
    }
}