DELETE from dbo.student;
DBCC CHECKIDENT('dbo.student', RESEED, 0);

Declare @Id int
Declare @FromDate date = '1980-01-01'
Declare @EndDate date = '2002-12-31'

Set @Id = 1

While @Id <= 15000
Begin 
   Insert Into dbo.student (first_name, last_name, dob, street, city, province, country, postal, total_credits)
   values (
        'First ' + CAST(@Id as nchar(20)),
        'Last ' + CAST(@Id as nchar(20)),
        dateadd(day, rand(checksum(NEWID()))*(1+datediff(day, @FromDate, @EndDate)), @FromDate),
        'Street ' + CAST(@Id as nchar(20)),
        'City ' + CAST(FLOOR(rand()*(6-1)+1) as nchar(20)),
        'Province ' + CAST(FLOOR(rand()*(4-1)+1) as nchar(20)),
        'Country ' + CAST(FLOOR(rand()*(3-1)+1) as nchar(20)),
        'Postal ' + CAST(@Id as nchar(20)),
        CAST(FLOOR(rand()*(120-0+1)+0) as int));

   Print @Id
   Set @Id = @Id + 1
End