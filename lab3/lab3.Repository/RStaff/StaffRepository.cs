using lab3.Repository.Domain;

namespace lab3.Repository.RStaff
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}