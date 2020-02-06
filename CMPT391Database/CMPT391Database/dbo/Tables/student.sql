CREATE TABLE [dbo].[student]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [first_name] NCHAR(20) NULL, 
    [last_name] NCHAR(20) NULL, 
    [dob] DATE NULL, 
    [street] NCHAR(20) NULL,
    [city] NCHAR(20) NULL,
    [province] NCHAR(20) NULL,
    [country] NCHAR(20) NULL,
    [postal] NCHAR(20) NULL,
    [total_credits] INT NULL
)
