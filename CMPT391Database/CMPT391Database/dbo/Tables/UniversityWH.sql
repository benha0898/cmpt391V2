CREATE TABLE [dbo].[UniversityWH]
(
	[student_id] INT NOT NULL, 
    [course_id] INT NOT NULL, 
    [instructor_id] INT NOT NULL, 
    [semester_id] INT NOT NULL, 
    [dept_id] INT NOT NULL, 
    [grade] FLOAT NULL,

    CONSTRAINT fk_universityWH_student FOREIGN KEY (student_id) REFERENCES studentWH (student_id) ON DELETE CASCADE,
	CONSTRAINT fk_universityWH_course FOREIGN KEY (course_id) REFERENCES courseWH (course_id) ON DELETE CASCADE,
    CONSTRAINT fk_universityWH_instructor FOREIGN KEY (instructor_id) REFERENCES instructorWH (instructor_id) ON DELETE CASCADE,
    CONSTRAINT fk_universityWH_semester FOREIGN KEY (semester_id) REFERENCES semesterWH (semester_id) ON DELETE CASCADE,
    CONSTRAINT fk_universityWH_dept FOREIGN KEY (dept_id) REFERENCES departmentWH (dept_id) ON DELETE CASCADE,
)
