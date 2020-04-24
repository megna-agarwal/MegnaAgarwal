using System;
using System.ComponentModel.DataAnnotations;
namespace lab3.Repository.Domain
{
    public class Staff
    {
        [Key]
        public int Staff_Id { get; set; }
        public int Staff_Role_Code { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}