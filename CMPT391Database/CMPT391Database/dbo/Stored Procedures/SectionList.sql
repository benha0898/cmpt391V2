CREATE PROCEDURE [dbo].[SectionList]
	@id int
AS
	SELECT vacancies FROM section WHERE id = @id
RETURN 0
