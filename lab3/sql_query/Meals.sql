use lab3DB;

CREATE TABLE Meals
(
    Meal_Id INT PRIMARY KEY IDENTITY(1,1),
    Customer_Id INT FOREIGN KEY REFERENCES Customers(Id),
    Staff_Id INT FOREIGN KEY REFERENCES Staff(Staff_Id),
    Date_of_Meal NVARCHAR(200),
    Cost_of_Meal NVARCHAR(200),
    Other_Details NVARCHAR(500),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);
