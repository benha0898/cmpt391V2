CREATE TABLE [dbo].time
(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	day NCHAR(10) NULL,
	start_time TIME NULL,
	end_time TIME NULL,
)
