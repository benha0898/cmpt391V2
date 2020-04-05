CREATE PROCEDURE [dbo].[ShowCourseList]
	@student_id int,
	@year int
AS
	SELECT subject, level, section_id as section, term, year
	FROM dbo.TakesSectionCourse WITH (NOEXPAND)
	WHERE	student_id = @student_id AND
			year = @year
	ORDER BY year DESC, term, subject, level, section
RETURN 0