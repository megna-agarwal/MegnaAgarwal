using System;
namespace lab3.Repository.Domain
{
    public class Ref_Staff_Role
    {
        public int Staff_Role_Code { get; set; }
        public string Staff_Role_Description { get; set; }
        public bool IsActive { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}