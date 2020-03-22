CREATE TABLE [dbo].[courseWH]
(
	[course_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [subject] VARCHAR(50) NULL, 
    [level] INT NULL, 
    [title] VARCHAR(50) NULL, 
    [credit] INT NULL DEFAULT 3
)
