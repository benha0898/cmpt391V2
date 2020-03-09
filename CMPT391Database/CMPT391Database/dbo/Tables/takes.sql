CREATE TABLE [dbo].takes
(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	student_id INT NULL,
	section_id INT NULL,
	grade FLOAT NULL,
	CONSTRAINT fk_takes_student FOREIGN KEY (student_id) REFERENCES student (id) ON DELETE CASCADE,
	CONSTRAINT fk_takes_section FOREIGN KEY (section_id) REFERENCES section (id) ON DELETE CASCADE,
)

GO

CREATE INDEX [IX_takes_student_id] ON [dbo].[takes] (student_id)

GO

CREATE INDEX [IX_takes_section_id] ON [dbo].[takes] (section_id)
