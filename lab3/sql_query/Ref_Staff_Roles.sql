
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

INSERT INTO Ref_Staff_Roles
    (
    Staff_Role_Description, IsActive, Other_Details, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn
    )
VALUES
    ('Sriya', 0 , 'part time', 'sysuser', '2019-01-03 10:00:00.000', 'sysuser', '2019-01-01 11:00:00.000'
);

