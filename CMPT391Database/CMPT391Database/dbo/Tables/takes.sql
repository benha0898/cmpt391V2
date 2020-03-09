CREATE TABLE [dbo].takes
(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	student_id INT NULL,
	section_id INT NULL,
	grade FLOAT NULL,
	CONSTRAINT fk_takes_student FOREIGN KEY (student_id) REFERENCES student (id),
	CONSTRAINT fk_takes_section FOREIGN KEY (section_id) REFERENCES section (id),
)

GO

CREATE INDEX [IX_takes_student_id] ON [dbo].[takes] (student_id)

GO

CREATE INDEX [IX_takes_section_id] ON [dbo].[takes] (section_id)
