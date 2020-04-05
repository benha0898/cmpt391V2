CREATE PROCEDURE [dbo].[GetCourse]
	@course nchar(10)
AS
	SELECT id, level
	FROM course
	WHERE subject = @course
RETURN 0
