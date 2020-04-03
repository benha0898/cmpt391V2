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
Declare @CourseId int = 0
Declare @CoursesTaken TABLE (course int)
Declare @bool int
Declare @rand BIGINT
DECLARE @maxid int = (SELECT MAX(id) FROM dbo.section);
Declare @Major nchar(4)
Declare @MajorMax int
Declare @MajorMin int
Declare @MajorCourseCount int
Declare @TotalMajorCourses int = 15
Declare @Prereqs TABLE (course int)
Declare @PrereqCount int
Declare @MaxPrereqs int
Declare @Year int
Declare @YearMax int
Declare @Term nchar(10)

SET @TotalCourses = 30
SELECT @TotalStudents = MAX(id) FROM dbo.student;

/* Create 30 courses for each student.
For each course, check to see if student has the prereqs */
Set @StudentCount = 1
While @StudentCount <= @TotalStudents
Begin
    DELETE FROM @CoursesTaken;
    SET @MajorCourseCount = 1;
    SELECT TOP 1 @Major = subject FROM course GROUP BY subject HAVING COUNT(*) > 18 ORDER BY NEWID();
    SELECT @MajorMax = MAX(id), @MajorMin = MIN(id) FROM course WHERE subject = @Major;
    SELECT TOP 1 @StudentId = id FROM student WHERE id=@StudentCount;
    Print 'StudentID: ' + CAST(@StudentId as varchar)
    --Print 'Major: ' + @Major

    SET @CourseCount = 1
    WHILE @CourseCount <= @TotalCourses
    BEGIN
        WHILE @MajorCourseCount <= @TotalMajorCourses
        BEGIN
            DELETE FROM @Prereqs;
            -- Select a random course in major
            -- Check if course is already taken
            SET @bool = 0
            WHILE @bool <> 1
            BEGIN
                SELECT TOP 1 @CourseId = id FROM course WHERE subject = @Major ORDER BY NEWID();
                IF @CourseId NOT IN (SELECT course FROM @CoursesTaken)
                BEGIN
                    SET @bool = 1
                    --PRINT 'Major Course: ' + CAST(@CourseId as varchar);
                END
            END;
            -- Get all the prereqs for that course
            WITH CTE_Prereq AS (
                SELECT course, prereq
                FROM prereq
                WHERE course = @CourseId
	                AND prereq NOT IN (SELECT course FROM @CoursesTaken)
                UNION ALL
                SELECT p.course, p.prereq
                FROM prereq p
                INNER JOIN CTE_Prereq o
	                ON o.prereq = p.course
                WHERE p.prereq NOT IN (SELECT course FROM @CoursesTaken))
            INSERT INTO @Prereqs (course)
            SELECT DISTINCT prereq FROM CTE_Prereq;
            INSERT INTO @Prereqs (course) VALUES (@CourseId);

            SELECT @MaxPrereqs = COUNT(*) FROM @Prereqs;
            IF @MaxPrereqs > 20
            BEGIN
                Print '@MaxPrereqs too high. Resetting...'
                CONTINUE
            END
            -- For each prereq, find a section and enroll
            SET @PrereqCount = 1
            SET @YearMax = 2020 - CEILING(@MaxPrereqs/2)
            SET @Year = FLOOR(RAND()*(@YearMax-2010+1))+2010
            SET @Term = CHOOSE(FLOOR(RAND()*(2-1+1))+1, 'Fall', 'Winter')
            WHILE @Term IS NULL
                SET @Term = CHOOSE(FLOOR(RAND()*(2-1+1))+1, 'Fall', 'Winter')
            WHILE (@PrereqCount <= @MaxPrereqs)
            BEGIN
                SELECT @CourseId = course
                FROM (
                    SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 100)) as idx, course
                    FROM @Prereqs) as temp
                WHERE idx = @PrereqCount;
                -- Select a section
                SELECT TOP 1 @SectionId = id FROM section WHERE course_id = @CourseId AND year = @Year AND term = @Term ORDER BY NEWID();
                -- Enroll
                --Print CAST(@CourseCount as varchar) + '. Enroll in major course ' + CAST(@CourseId as varchar) + '. Section ' + CAST(@SectionId as varchar)
                INSERT INTO takes (student_id, section_id, grade)
                VALUES (
                    @StudentId,
                    @SectionId,
                    ROUND(RAND()*(4-1)+1,1)); -- GPA From 1.0 to 4.0

                INSERT INTO @CoursesTaken VALUES (@CourseId);
                SET @CourseCount = @CourseCount + 1
                SET @PrereqCount = @PrereqCount + 1
                IF @Term = 'Winter'
                BEGIN
                    SET @Term = 'Fall'
                END
                ELSE
                BEGIN
                    SET @Term = 'Winter'
                    SET @Year = @Year + 1
                END
                IF (@CourseId >= @MajorMin AND @CourseId <= @MajorMax)
                BEGIN
                    SET @MajorCourseCount = @MajorCourseCount + 1
                END
                IF @MajorCourseCount >= 20
                    BREAK
            END
        END
        -- After all major courses has been enrolled, we can enroll the rest
        -- Make sure the course is not already taken by student
        SET @bool = 0
        WHILE @bool <> 1
        BEGIN
            SELECT @rand = ABS((CHECKSUM(NEWID()))) % @maxid;
            SELECT TOP 1 @SectionId = id, @CourseId = course_id FROM section WHERE id >= @rand;
            IF @CourseId NOT IN (SELECT course FROM @CoursesTaken)
            BEGIN
                SET @bool = 1
                --PRINT 'Non-Major Course: ' + CAST(@CourseId as varchar);
            END
        END
        -- Check for prereqs
        IF NOT EXISTS (
            SELECT p.prereq
            FROM prereq p
            WHERE   p.course = @CourseId AND
                    p.prereq NOT IN (SELECT course FROM @CoursesTaken))
        BEGIN
            -- Enroll
            --Print CAST(@CourseCount as varchar) + '. Enroll in course ' + CAST(@CourseId as varchar)
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