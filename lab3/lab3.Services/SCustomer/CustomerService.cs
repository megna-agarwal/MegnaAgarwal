using lab3.Repository.Domain;
using lab3.Repository.RCustomer;
namespace lab3.Services.SCustomer
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository) :
        base(customerRepository)
        {

        }
    }
}