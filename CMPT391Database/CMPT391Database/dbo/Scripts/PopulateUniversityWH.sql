/* Populate UniversityWH table */
DELETE FROM dbo.UniversityWH;

INSERT INTO UniversityWH (student_id, course_id, instructor_id, semester_id, dept_id, grade)
SELECT st.student_id, s.course_id, c.instructor_id, sem.semester_id, c.dept_id, t.grade
FROM takes t, studentWH st, section s, courseWH c, semesterWH sem
WHERE	t.student_id = st.student_id AND
		t.section_id = s.id AND
		s.course_id = c.course_id AND
		s.term = sem.term AND
		s.year = sem.year;