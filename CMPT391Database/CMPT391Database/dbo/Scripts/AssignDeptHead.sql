UPDATE department
SET department.dept_head = (
	SELECT TOP 1 id
	FROM instructor
	WHERE instructor.dept = department.dept_name
	ORDER BY NEWID());