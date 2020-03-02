using System;
using System.ComponentModel.DataAnnotations;
namespace lab3.Repository.Domain
{
    public class Menu
    {
        [Key]
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public string Available_Date_From { get; set; }
        public string Available_Date_To { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}