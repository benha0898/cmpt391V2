/* Populate CourseWH table */
DELETE from dbo.courseWH;
DBCC CHECKIDENT('dbo.courseWH', RESEED, 0);

INSERT INTO dbo.courseWH (subject, level)
SELECT subject, level
FROM dbo.course;

UPDATE dbo.courseWH
SET dept_id =
	CASE
		WHEN subject = 'ACCT' THEN 20
		WHEN subject = 'BIOL' THEN 2
		WHEN subject = 'BUSN' THEN 19
		WHEN subject = 'CHEM' THEN 7
		WHEN subject = 'CMPT' THEN 3
		WHEN subject = 'DESN' THEN 10
		WHEN subject = 'EASC' THEN 7
		WHEN subject = 'ECON' THEN 1
		WHEN subject = 'ENGL' THEN 4
		WHEN subject = 'FNCE' THEN 20
		WHEN subject = 'HIST' THEN 5
		WHEN subject = 'MARK' THEN 22
		WHEN subject = 'MATH' THEN 6
		WHEN subject = 'MGMT' THEN 19
		WHEN subject = 'MUSC' THEN 13
		WHEN subject = 'NURS' THEN 24
		WHEN subject = 'PHIL' THEN 5
		WHEN subject = 'PHYS' THEN 7
		WHEN subject = 'PSYC' THEN 8
		WHEN subject = 'SOCI' THEN 9
		WHEN subject = 'STAT' THEN 6
		WHEN subject = 'WRIT' THEN 4
	END
WHERE subject IN (SELECT DISTINCT subject FROM dbo.courseWH);

UPDATE courseWH
SET courseWH.instructor_id = temp.instructor_id
FROM courseWH
CROSS APPLY (SELECT TOP 1 i.instructor_id
            FROM instructorWH i
            WHERE	courseWH.course_id = courseWH.course_id AND
					courseWH.dept_id = i.dept_id
            ORDER BY NEWID()) temp;