CREATE TABLE [dbo].section
(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	course_id INT NULL,
	term NCHAR(10) NULL,
	year INT NULL,
	capacity INT NULL,
	vacancies INT NULL,
	classroom NCHAR(10) NULL,
	time_id INT NULL,
	CONSTRAINT fk_section_time FOREIGN KEY (time_id) REFERENCES time (id),
	CONSTRAINT fk_section_course FOREIGN KEY (course_id) REFERENCES course (id) ON DELETE CASCADE
)

GO

CREATE INDEX [IX_section_course_id] ON [dbo].[section] ([course_id])
