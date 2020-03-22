/* Populate CourseWH table */
DELETE from dbo.courseWH;
DBCC CHECKIDENT('dbo.courseWH', RESEED, 0);

INSERT INTO dbo.courseWH (subject, level)
SELECT subject, level
FROM dbo.course;