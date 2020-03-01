using lab3.Repository.Domain;
using lab3.Repository.RStaff;
namespace lab3.Services.SStaff
{
    public class StaffService : GenericService<Staff>, IStaffService
    {
        public StaffService(IStaffRepository staffRepository) :
        base(staffRepository)
        {

        }
    }
}