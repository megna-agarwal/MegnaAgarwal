use lab3DB;

CREATE TABLE Staff
(
    Staff_Id INT PRIMARY KEY IDENTITY(1,1),
    Staff_Role_Code INT FOREIGN KEY REFERENCES Ref_Staff_Roles(Staff_Role_Code),
    First_Name NVARCHAR(200),
    Last_Name NVARCHAR(200),
    Other_Details NVARCHAR(200),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);

