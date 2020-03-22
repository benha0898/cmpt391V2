/* Populate SemesterWH table */
DELETE from dbo.semesterWH;
DBCC CHECKIDENT('dbo.semesterWH', RESEED, 0);

Declare @YearVar int
Declare @TermVar int
Set @YearVar = 2010

While @YearVar <= 2020
BEGIN
    Set @TermVar = 1
    While @TermVar <= 3
    BEGIN
        Insert Into dbo.semesterWH(term, year)
        Values (
                CHOOSE(@TermVar, 'Winter', 'Spring/Summer', 'Fall'),
                @YearVar);
        Set @TermVar = @TermVar + 1
    END
    Set @YearVar = @YearVar + 1
END