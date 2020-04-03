CREATE TABLE [dbo].[prereq]
( 
    [course] INT NULL, 
    [prereq] INT NULL,
)
GO

IF (OBJECT_ID('dbo.fk_prereq_course', 'F') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.prereq DROP CONSTRAINT fk_prereq_course;
END
GO

IF (OBJECT_ID('dbo.fk_prereq_prereq', 'F') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.prereq DROP CONSTRAINT fk_prereq_prereq;
END
GO

ALTER TABLE [dbo].[prereq]
    ADD CONSTRAINT fk_prereq_course FOREIGN KEY (course) REFERENCES course (id) ON DELETE CASCADE;
GO
ALTER TABLE [dbo].[prereq]
    ADD CONSTRAINT fk_prereq_prereq FOREIGN KEY (prereq) REFERENCES course (id) ON DELETE CASCADE;
GO

CREATE INDEX [IX_prereq_course] ON [dbo].[prereq] ([course])

GO

CREATE INDEX [IX_prereq_prereq] ON [dbo].[prereq] ([prereq])
