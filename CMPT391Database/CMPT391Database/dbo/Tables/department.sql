CREATE TABLE [dbo].[department]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [dept_name] NCHAR(20) UNIQUE NULL,
	[building] INT NULL,
	[dept_head] INT UNIQUE NULL,
	CONSTRAINT fk_department_instructor FOREIGN KEY (dept_head) REFERENCES instructor ([id]),
)
