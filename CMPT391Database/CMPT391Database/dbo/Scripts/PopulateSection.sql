/* Populate Section table */
DELETE from dbo.section;
DBCC CHECKIDENT('dbo.section', RESEED, 0);

SET NOCOUNT ON

Declare @Id int
Declare @Total int
Declare @YearVar int
Declare @SectionVar int
Declare @CourseIdVar int
Declare @TermVar int
Declare @LevelVar int

Set @Id = 1
SELECT @Total = MAX(id) FROM dbo.course;
PRINT 'Total Courses: ' + CAST(@Total as varchar)

/* For each course, create 1-3 sections for every semester from
Fall 2020 to Winter 2020.
Capacity = 30.
Time is selected randomly from time table. */

While @Id <= @Total
Begin
    IF @Id NOT IN (SELECT id FROM course WHERE id = @Id)
    BEGIN
        Print 'Id ' + CAST(@Id as varchar) + ' doesnt exist'
        Set @Id = @Id + 1
        CONTINUE
    END
    SELECT TOP 1 @CourseIdVar = id, @LevelVar = CAST(SUBSTRING(CAST(level as nchar(10)), 1, 1) as int)
    FROM course
    WHERE id=@Id;

    Set @LevelVar = CASE @LevelVar
        WHEN 1 THEN 3
        WHEN 2 THEN 2
        WHEN 3 THEN 1
        WHEN 4 THEN 1
        ELSE 0
    END
    Print CAST(@CourseIdVar as varchar)

    Set @YearVar = 2010
    While @YearVar <= 2020
    BEGIN
        Set @TermVar = 1
        While @TermVar <= 2
        BEGIN
            Set @SectionVar = 1
            While @SectionVar <= @LevelVar
            BEGIN
                Insert Into section(course_id, term, year, capacity, time_id)
                Values (
                    @CourseIdVar,
                    CHOOSE(@TermVar, 'Fall', 'Winter'),
                    @YearVar,
                    30,
                    (SELECT TOP 1 id FROM time ORDER BY NEWID()));
                Set @SectionVar = @SectionVar + 1
            END
            Set @TermVar = @TermVar + 1
        END
        Set @YearVar = @YearVar + 1
    END
    Set @Id = @Id + 1
END