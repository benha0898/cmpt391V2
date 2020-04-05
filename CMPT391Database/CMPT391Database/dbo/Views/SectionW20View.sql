-- Create View with Schemabinding
CREATE VIEW [dbo].[SectionW20View] WITH SCHEMABINDING
	AS SELECT id, course_id, vacancies FROM dbo.section WHERE term = 'Winter' AND year = 2020;
GO
CREATE UNIQUE CLUSTERED INDEX [IX_SectionW20View_id]
    ON [dbo].[SectionW20View]([id] ASC);