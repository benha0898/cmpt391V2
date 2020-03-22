CREATE TABLE [dbo].[instructorWH]
(
	[instructor_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] VARCHAR(50) NULL, 
    [dept_id] INT NULL,

    CONSTRAINT fk_instructorWH_dept FOREIGN KEY (dept_id) REFERENCES departmentWH (dept_id) ON DELETE NO ACTION,
)
