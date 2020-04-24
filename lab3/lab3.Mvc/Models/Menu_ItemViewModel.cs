using System;
using System.ComponentModel.DataAnnotations;
namespace lab3.Repository.Domain
{
    public class Menu_Item
    {
        [Key]
        public int Menu_Item_Id { get; set; }
        public int Menu_Id { get; set; }
        public string Menu_Item_Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}