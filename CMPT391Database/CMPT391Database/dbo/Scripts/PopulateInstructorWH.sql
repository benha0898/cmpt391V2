/* Populate InstructorWH table */
DELETE from dbo.instructorWH;
DBCC CHECKIDENT('dbo.instructorWH', RESEED, 0);

Declare @Id int

Set @Id = 1

While @Id <= 500
Begin
    INSERT INTO dbo.instructorWH (name, dept_id)
    VALUES (
        'Instructor ' + CAST(@Id as varchar),
        (SELECT TOP 1 dept_id FROM dbo.departmentWH ORDER BY NEWID()));

    SET @Id = @Id + 1
End