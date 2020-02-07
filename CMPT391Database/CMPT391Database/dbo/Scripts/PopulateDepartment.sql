/* Populate Department table */
DELETE from dbo.department;
DBCC CHECKIDENT('dbo.department', RESEED, 0);

Insert Into dbo.department (dept_name, building)
Values
    ('Anthropology, Economics and Political Science', 6),
    ('Biological Sciences', 6),
    ('Computer Science', 5),
    ('English', 6),
    ('Humanities', 7),
    ('Mathematics and Statistics', 5),
    ('Physical Sciences', 5),
    ('Psychology', 6),
    ('Sociology', 6),
    ('Art and Design', 11),
    ('Arts and Cultural Management', 11),
    ('Communication', 11),
    ('Music', 11),
    ('Theatre', 11),
    ('Allied Health and Human Performance', 9),
    ('Child and Youth Care', 9),
    ('Human Services and Early Learning', 9), 
    ('Public Safety and Justice Studies', 9),
    ('Organizational Behaviour, Human Resources Management and Management', 5),
    ('Accounting and Finance', 5),
    ('Decision Sciences', 5),
    ('International Business, Marketing, Strategy and Law', 5),
    ('Interprofessional Education and Simulation Learning (DIESL)', 9),
    ('Psychiatric Nursing', 9),
    ('Nursing Science', 9);
