CREATE TABLE [dbo].[courseWH]
(
	[course_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [subject] VARCHAR(50) NULL, 
    [level] INT NULL, 
    [title] VARCHAR(50) NULL, 
    [credit] INT NULL DEFAULT 3, 
    [dept_id] INT NULL, 
    [instructor_id] INT NULL,

    CONSTRAINT fk_courseWH_dept FOREIGN KEY (dept_id) REFERENCES departmentWH (dept_id) ON DELETE NO ACTION,
    CONSTRAINT fk_courseWH_instructor FOREIGN KEY (instructor_id) REFERENCES instructorWH (instructor_id) ON DELETE NO ACTION,
)
