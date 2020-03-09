/* Populate Takes table */
DELETE from dbo.takes;
DBCC CHECKIDENT('dbo.takes', RESEED, 0);

Declare @StudentCount int
Declare @TotalStudents int
Declare @CourseCount int
Declare @TotalCourses int
Declare @StudentId int
Declare @SectionId int
Declare @CourseId int
Declare @CourseVar nchar(5)
Declare @LevelVar int

SET @TotalCourses = 30
SELECT @TotalStudents = COUNT(*) FROM dbo.student;

/* Create 30 courses for each student.
For each course, check to see if student has the prereqs */

Set @StudentCount = 1
While @StudentCount <= @TotalStudents
Begin
    SELECT TOP 1 @StudentId = id FROM student WHERE id=@StudentCount;
    Print 'StudentID: ' + CAST(@StudentId as varchar)

    SET @CourseCount = 1
    WHILE @CourseCount <= @TotalCourses
    BEGIN
        SELECT TOP 1 @SectionId = id, @CourseId = course_id FROM section ORDER BY NEWID();
        
        /* Check for Prereqs */
        IF @CourseId IN (
            select distinct course_id
            from section s
            where not exists (
	            select *
	            from prereq p, section s2
	            where
		            p.course = s.course_id
		        and p.prereq = s2.course_id
		        and (
                    (s2.id not in (
			            select section_id
                        from takes
                        where student_id = @StudentId))
                    or
                    (s2.id in (
                        select section_id
                        from takes
                        where student_id=@StudentId)
                    and ((s2.year > s.year)
                        or (s2.year = s.year and s.term <> 'Fall'))
                    )
                    )
                )
            and not exists (
                select *
                from takes
                where student_id = @StudentId and section_id = @SectionId))
        BEGIN
            Insert Into takes (student_id, section_id, grade)
            values (
                @StudentId,
                @SectionId,
                ROUND(RAND()*(4-1)+1,1)); -- GPA From 1.0 to 4.0

            SET @CourseCount = @CourseCount + 1
        END
    END
    SET @StudentCount = @StudentCount + 1
End