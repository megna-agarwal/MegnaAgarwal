
use lab3DB;

CREATE TABLE Menus
(
    Menu_Id INT PRIMARY KEY IDENTITY(1,1),
    Menu_Name NVARCHAR(200),
    Available_Date_From DATETIME,
    Available_Date_To DATETIME,
    Other_Details NVARCHAR(200),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);

INSERT INTO Menus
    (
    Menu_Name, Available_Date_From, Available_Date_To, Other_Details, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn
    )
VALUES
    ('Vegetarian Menu', getdate(), GETDATE(), 'Pure Vegetarian', 'sysuser', GETDATE(), 'sysuser', GETDATE()
)
