/* Populate InstructorWH table */
DELETE from dbo.instructorWH;
DBCC CHECKIDENT('dbo.instructorWH', RESEED, 0);

Declare @Id int

Set @Id = 1

While @Id <= 500
Begin
    INSERT INTO dbo.instructorWH (name)
    VALUES (
        'Instructor ' + CAST(@Id as varchar));

    SET @Id = @Id + 1
End