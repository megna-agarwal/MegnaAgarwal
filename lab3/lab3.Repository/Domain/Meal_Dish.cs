using System;
using System.ComponentModel.DataAnnotations;
namespace lab3.Repository.Domain
{
    public class Meal_Dish
    {
        [Key]
        public int Meal_Id { get; set; }
        public int Menu_Item_id { get; set; }
        public int Quantity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}