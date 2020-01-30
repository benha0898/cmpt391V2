CREATE TABLE [dbo].[instructor]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [first_name] NCHAR(20) NULL,
	[last_name] NCHAR(20) NULL,
	[dob] DATE NULL,
	[dept] NCHAR(20) NULL,
	[salary] INT NULL,
	CONSTRAINT fk_instructor_department FOREIGN KEY (dept) REFERENCES department (dept_name),
)
