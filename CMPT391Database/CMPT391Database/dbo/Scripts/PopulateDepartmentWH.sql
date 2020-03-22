/* Populate DepartmentWH table */
DELETE from dbo.departmentWH;
DBCC CHECKIDENT('dbo.departmentWH', RESEED, 0);

Insert Into dbo.departmentWH (department, faculty)
Values
    ('Anthropology, Economics and Political Science', 'Arts and Science'),
    ('Biological Sciences', 'Arts and Science'),
    ('Computer Science', 'Arts and Science'),
    ('English', 'Arts and Science'),
    ('Humanities', 'Arts and Science'),
    ('Mathematics and Statistics', 'Arts and Science'),
    ('Physical Sciences', 'Arts and Science'),
    ('Psychology', 'Arts and Science'),
    ('Sociology', 'Arts and Science'),
    ('Art and Design', 'Fine Arts and Communications'),
    ('Arts and Cultural Management', 'Fine Arts and Communications'),
    ('Communication', 'Fine Arts and Communications'),
    ('Music', 'Fine Arts and Communications'),
    ('Theatre', 'Fine Arts and Communications'),
    ('Allied Health and Human Performance', 'Health and Community Studies'),
    ('Child and Youth Care', 'Health and Community Studies'),
    ('Human Services and Early Learning', 'Health and Community Studies'), 
    ('Public Safety and Justice Studies', 'Health and Community Studies'),
    ('Organizational Behaviour, Human Resources Management and Management', 'Business'),
    ('Accounting and Finance', 'Business'),
    ('Decision Sciences', 'Business'),
    ('International Business, Marketing, Strategy and Law', 'Business'),
    ('Interprofessional Education and Simulation Learning (DIESL)', 'Nursing'),
    ('Psychiatric Nursing', 'Nursing'),
    ('Nursing Science', 'Nursing');