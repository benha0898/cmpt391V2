
CREATE PROCEDURE [dbo].[student_insert]
	@id int,
	@first_name nchar(20),
	@last_name nchar(20),
	@dob date,
	@street nchar(20),
	@city nchar(20),
	@province nchar(20),
	@country nchar(20),
	@postal nchar(20),
	@total_credits int
AS
	BEGIN

		insert into student (id,first_name,last_name,dob,street,city,province,country,postal,total_credits)values(@id,@first_name,@last_name,@dob,@street,@city,@province,@country,@postal,@total_credits)
END
GO
