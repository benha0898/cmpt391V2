CREATE TABLE [dbo].course
(
	id INT NOT NULL PRIMARY KEY,
	subject NCHAR(10) NULL,
	level INT NULL,
	title NCHAR(30) NULL,
	description NCHAR(100) NULL,
	dept NCHAR(100) NULL,
	credit INT NULL,
	CONSTRAINT fk_course_department FOREIGN KEY (dept) REFERENCES department (dept_name),
)