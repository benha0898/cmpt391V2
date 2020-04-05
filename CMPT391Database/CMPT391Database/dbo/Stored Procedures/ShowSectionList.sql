CREATE PROCEDURE [dbo].[ShowSectionList]
	@term nchar(10),
	@year int,
    @course_id int
AS
    IF (@term = 'Fall' AND @year = 2020)
	    SELECT id FROM SectionF20View WHERE course_id = @course_id
	ELSE IF (@term = 'Winter' AND @year = 2020)
		SELECT id FROM SectionW20View WHERE course_id = @course_id
RETURN 0