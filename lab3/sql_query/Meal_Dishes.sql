use lab3DB;

CREATE TABLE Meal_Dishes
(
    Meal_Id INT FOREIGN KEY REFERENCES Meals(Meal_Id),
    Menu_Item_id INT FOREIGN KEY REFERENCES Menu_Items(Menu_Item_id),
    Quantity INT,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);
