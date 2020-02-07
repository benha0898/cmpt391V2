/* Populate Instructor table */
DELETE from dbo.instructor;
DBCC CHECKIDENT('dbo.instructor', RESEED, 0);

Declare @Id int
Declare @FromDate date = '1950-01-01'
Declare @EndDate date = '1992-12-31'

Set @Id = 1

While @Id <= 500
Begin
    Insert Into dbo.instructor (first_name, last_name, dob, dept, salary)
    Values (
        'First ' + CAST(@Id as nchar(20)),
        'Last ' + CAST(@Id as nchar(20)),
        dateadd(day, rand(checksum(NEWID()))*(1+datediff(day, @FromDate, @EndDate)), @FromDate),
        (SELECT TOP 1 dept_name FROM dbo.department ORDER BY NEWID()),
        CAST(FLOOR(rand()*(110-40+1)+40)*1000 as int));

    Set @Id = @Id + 1
End