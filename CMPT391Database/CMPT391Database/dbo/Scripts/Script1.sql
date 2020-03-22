/* Update Section's vacancy */
SET NOCOUNT OFF

Declare @SectionCount int
Declare @TotalSections int
Declare @Count int

SELECT @TotalSections = COUNT(*) FROM dbo.section;

Set @SectionCount = 1
While @SectionCount <= @TotalSections
Begin
    SELECT @Count = COUNT(section_id)
    FROM takes
    WHERE section_id=@SectionCount;

    IF @Count <= 30
    BEGIN
        UPDATE section
        SET vacancies = 30 - @Count
        WHERE section.id = @SectionCount;
    END
    ELSE
    BEGIN
        UPDATE section
        SET capacity = @Count, vacancies = 0
        WHERE section.id = @SectionCount;
    END

    SET @SectionCount = @SectionCount + 1;
End