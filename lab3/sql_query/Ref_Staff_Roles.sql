
use lab3DB;

CREATE TABLE Ref_Staff_Roles
(
    Staff_Role_Code INT PRIMARY KEY IDENTITY(1,1),
    Staff_Role_Description NVARCHAR(200),
    IsActive BIT,
    Other_Details NVARCHAR(200),
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);
