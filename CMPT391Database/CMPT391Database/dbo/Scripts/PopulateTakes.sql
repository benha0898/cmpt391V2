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
Declare @CoursesTaken TABLE (course int)
Declare @bool int
Declare @rand BIGINT
DECLARE @maxid int = (SELECT MAX(id) FROM dbo.section);

SET @TotalCourses = 30
SELECT @TotalStudents = MAX(id) FROM dbo.student;

/* Create 30 courses for each student.
For each course, check to see if student has the prereqs */

Set @StudentCount = 1
While @StudentCount <= @TotalStudents
Begin
    DELETE FROM @CoursesTaken;
    SELECT TOP 1 @StudentId = id FROM student WHERE id=@StudentCount;
    Print 'StudentID: ' + CAST(@StudentId as varchar)

    SET @CourseCount = 1
    WHILE @CourseCount <= @TotalCourses
    BEGIN
        -- Make sure the course is not already taken by student
        SET @bool = 0
        WHILE @bool <> 1
        BEGIN
            SELECT @rand = ABS((CHECKSUM(NEWID()))) % @maxid;
            SELECT TOP 1 @SectionId = id, @CourseId = course_id FROM section WHERE id >= @rand;
            IF @CourseId NOT IN (SELECT course FROM @CoursesTaken)
            BEGIN
                SET @bool = 1
            END
        END
        -- Check for Prereqs in 2 steps
        -- 1. If there's no prereq that student hasn't completed
        IF NOT EXISTS (
            SELECT p.prereq
            FROM prereq p, section s
            WHERE   p.course = @CourseId AND
                    s.id NOT IN (
                        SELECT s.id FROM takes t
                        WHERE   t.student_id = @StudentId AND
                                s.id = t.section_id) AND
                    p.prereq = s.course_id)
        BEGIN
            INSERT INTO takes (student_id, section_id, grade)
            VALUES (
                @StudentId,
                @SectionId,
                ROUND(RAND()*(4-1)+1,1)); -- GPA From 1.0 to 4.0

            INSERT INTO @CoursesTaken VALUES (@CourseId);
            SET @CourseCount = @CourseCount + 1
        END
    END
    SET @StudentCount = @StudentCount + 1
End