CREATE TABLE [dbo].[prereq]
( 
    [course] INT NULL, 
    [prereq] INT NULL,
    CONSTRAINT fk_prereq_course FOREIGN KEY (course) REFERENCES course (id),
    CONSTRAINT fk_prereq_prereq FOREIGN KEY (prereq) REFERENCES course (id)
)

GO

CREATE INDEX [IX_prereq_course] ON [dbo].[prereq] ([course])

GO

CREATE INDEX [IX_prereq_prereq] ON [dbo].[prereq] ([prereq])
