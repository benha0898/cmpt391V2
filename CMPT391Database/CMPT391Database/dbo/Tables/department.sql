CREATE TABLE [dbo].[department]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [dept_name] NCHAR(100) UNIQUE NULL,
	[building] INT NULL,
	[dept_head] INT NULL,
	CONSTRAINT fk_department_instructor FOREIGN KEY (dept_head) REFERENCES instructor ([id]),
)

GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_department_depthead]
ON [dbo].[department] ([dept_head])
WHERE dept_head IS NOT NULL;
