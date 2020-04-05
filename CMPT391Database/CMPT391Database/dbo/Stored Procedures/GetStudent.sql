CREATE PROCEDURE [dbo].[GetStudent]
	@id int
AS
	SELECT first_name + ' ' + last_name AS full_name FROM student WHERE id = @id
RETURN 0
