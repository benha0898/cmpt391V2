CREATE TABLE [dbo].takes
(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	student_id INT NULL,
	section_id INT NULL,
	grade FLOAT NULL,
	CONSTRAINT fk_takes_student FOREIGN KEY (student_id) REFERENCES student (id) ON DELETE CASCADE,
	CONSTRAINT fk_takes_section FOREIGN KEY (section_id) REFERENCES section (id) ON DELETE CASCADE,
	CONSTRAINT uc_takes_take UNIQUE (student_id, section_id)
)

GO

CREATE INDEX [IX_takes_student_id] ON [dbo].[takes] (student_id)

GO

CREATE INDEX [IX_takes_student_section] ON [dbo].[takes] (student_id, section_id)
