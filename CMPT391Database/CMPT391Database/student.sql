CREATE TABLE [dbo].[student]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [first_name] NCHAR(10) NULL, 
    [last_name] NCHAR(10) NULL, 
    [dob] DATE NULL, 
    [street] NCHAR(20) NULL,
    [city] NCHAR(20) NULL,
    [province] NCHAR(20) NULL,
    [country] NCHAR(20) NULL,
    [postal] NCHAR(10) NULL,
    [total_credits] INT NULL
)
