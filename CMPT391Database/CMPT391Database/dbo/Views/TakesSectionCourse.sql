CREATE VIEW [dbo].[TakesSectionCourse]
WITH SCHEMABINDING
AS
	SELECT	t.student_id as student_id,
			t.section_id as section_id,
			s.course_id as course_id,
			c.subject as subject,
			c.level as level,
			s.term as term,
			s.year as year
	FROM	dbo.takes t, dbo.section s, dbo.course c
	WHERE	t.section_id = s.id AND
			s.course_id = c.id

GO

CREATE UNIQUE CLUSTERED INDEX UCIDX_student_section
ON dbo.TakesSectionCourse (student_id, section_id);

GO