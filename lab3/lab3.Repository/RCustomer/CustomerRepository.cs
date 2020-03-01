using lab3.Repository.Domain;

namespace lab3.Repository.RCustomer
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}