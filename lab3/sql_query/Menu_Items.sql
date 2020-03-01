use lab3DB;

CREATE TABLE Menu_Items
(
    Menu_Item_Id INT PRIMARY KEY IDENTITY(1,1),
    Menu_Id INT FOREIGN KEY REFERENCES Menus(Menu_Id),
    Menu_Item_Name NVARCHAR(200),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);
