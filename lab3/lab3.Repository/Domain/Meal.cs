using System;
using System.ComponentModel.DataAnnotations;
namespace lab3.Repository.Domain
{
    public class Meal
    {
        [Key]

        public int Meal_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Staff_Id { get; set; }
        public string Date_of_Meal { get; set; }
        public string Cost_of_Meal { get; set; }
        public string Other_Details { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}