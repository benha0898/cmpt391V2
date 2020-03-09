/* Populate Takes table */
DELETE from dbo.takes;
DBCC CHECKIDENT('dbo.takes', RESEED, 0);

SET NOCOUNT ON

Declare @StudentCount int
Declare @TotalStudents int
Declare @CourseCount int
Declare @TotalCourses int
Declare @StudentId int
Declare @SectionId int
Declare @CourseId int

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
        
        -- Check for Prereqs in 2 steps
        -- 1. If there's no prereq that student hasn't completed
        IF NOT EXISTS (
            SELECT p.prereq
            FROM prereq p, section s
            WHERE   p.course = @CourseId AND
                    s.id IN (
                        SELECT s.id FROM takes t
                        WHERE   t.student_id = @StudentId AND
                                s.id = t.section_id) AND
                    p.prereq = s.course_id)
        -- 2. And if the course hasn't been taken already
        AND NOT EXISTS (
            SELECT section_id
            FROM takes
            WHERE   student_id = @StudentId AND
                    section_id = @SectionId)
        BEGIN
            INSERT INTO takes (student_id, section_id, grade)
            VALUES (
                @StudentId,
                @SectionId,
                ROUND(RAND()*(4-1)+1,1)); -- GPA From 1.0 to 4.0

            SET @CourseCount = @CourseCount + 1
        END
    END
    SET @StudentCount = @StudentCount + 1
End