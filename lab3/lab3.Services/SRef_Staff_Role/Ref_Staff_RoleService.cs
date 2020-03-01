using lab3.Repository.Domain;
using lab3.Repository.RRef_Staff_Role;
namespace lab3.Services.SRef_Staff_Role
{
    public class Ref_Staff_RoleService : GenericService<Ref_Staff_Role>, IRef_Staff_RoleService
    {
        public Ref_Staff_RoleService(IRef_Staff_RoleRepository ref_Staff_RoleRepository) :
        base(ref_Staff_RoleRepository)
        {

        }
    }
}