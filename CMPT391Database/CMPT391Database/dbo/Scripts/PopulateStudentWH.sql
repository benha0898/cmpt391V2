/* Populate StudentWH table */
DELETE from dbo.studentWH;
DBCC CHECKIDENT('dbo.studentWH', RESEED, 0);

Declare @Id int

Set @Id = 1

While @Id <= 15000
Begin
    INSERT INTO dbo.studentWH (name, address)
    VALUES (
        'Student ' + CAST(@Id as varchar),
        'Address ' + CAST(@Id as varchar));

    SET @Id = @Id + 1
End