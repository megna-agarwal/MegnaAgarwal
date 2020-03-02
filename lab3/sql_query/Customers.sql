use lab3DB;

CREATE TABLE Customers
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(200),
    LastName NVARCHAR(200),
    Address NVARCHAR(500),
    PhoneRes NVARCHAR(50),
    PhoneMob NVARCHAR(50),
    EnrollDate DATETIME,
    IsActive BIT,
    CreatedBy NVARCHAR(200),
    CreatedOn DATETIME,
    UpdatedBy NVARCHAR(200),
    UpdatedOn DATETIME
);

INSERT INTO Customers
    (
    FirstName, LastName, Address, PhoneRes, PhoneMob, EnrollDate, IsActive, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn
    )
VALUES
    ('Sriya', 'Magar', 'Pokhara', '4123567', '9876543210', '2019-01-02 00:00:00.000', 1, 'sysuser', '2019-01-03 10:00:00.000', 'sysuser', '2019-01-01 11:00:00.000'
);

