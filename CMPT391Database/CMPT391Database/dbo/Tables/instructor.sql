CREATE TABLE [dbo].[instructor]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [first_name] NCHAR(20) NULL,
	[last_name] NCHAR(20) NULL,
	[dob] DATE NULL,
	[dept] NCHAR(100) NULL,
	[salary] INT NULL,
	CONSTRAINT fk_instructor_department FOREIGN KEY (dept) REFERENCES department (dept_name),
)
