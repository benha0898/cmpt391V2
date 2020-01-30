CREATE TABLE [dbo].section
(
	id INT NOT NULL PRIMARY KEY,
	course_id INT NULL,
	term NCHAR(10) NULL,
	year INT NULL,
	capacity INT NULL,
	classroom NCHAR(10) NULL,
	time_id INT NULL,
	CONSTRAINT fk_section_time FOREIGN KEY (time_id) REFERENCES time (id),
)
