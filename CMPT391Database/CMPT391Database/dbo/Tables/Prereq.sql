CREATE TABLE [dbo].[prereq]
( 
    [course] INT NULL, 
    [prereq] INT NULL,
    CONSTRAINT fk_prereq_course FOREIGN KEY (course) REFERENCES course (id),
    CONSTRAINT fk_prereq_prereq FOREIGN KEY (prereq) REFERENCES course (id)
)
