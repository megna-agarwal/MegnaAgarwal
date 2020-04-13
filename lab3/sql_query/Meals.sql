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


INSERT INTO Meals
    (
    Customer_Id, Staff_Id, Date_of_Meal, Cost_of_Meal, Other_Details, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn
    )
VALUES
    (1, 'Magar', 'Pokhara', '4123567', '9876543210', '2019-01-02 00:00:00.000', 1, 'sysuser', '2019-01-03 10:00:00.000', 'sysuser', '2019-01-01 11:00:00.000'
);


