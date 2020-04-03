-- Create View with Schemabinding
CREATE VIEW [dbo].[SectionF20View] WITH SCHEMABINDING
	AS SELECT id, course_id, vacancies FROM dbo.section WHERE term = 'Fall' AND year = 2020;
GO
-- Create an index for the view
CREATE UNIQUE CLUSTERED INDEX IX_SectionW20View_id
	ON dbo.SectionF20View (id);