/* Populate Time table */
DELETE FROM dbo.time;
DBCC CHECKIDENT('dbo.time', RESEED, 0);

DECLARE @DaysList TABLE (idx int identity(1,1), days nchar(10));
INSERT INTO @DaysList(days) VALUES
    ('M'),('T'),('W'),('R'),('F'),('MW'),('WF'),('TR'),('MWF');
DECLARE @StartTimeList TABLE (idx int identity(1,1), times time(7));
INSERT @StartTimeList(times) VALUES
    ('08:00'),('09:00'),('09:30'),('10:00'),('11:00'),('12:00'),
    ('12:30'),('13:00'),('14:00'),('15:00'),('16:00'),('18:00');

DECLARE @i int;
DECLARE @dcount int;
SELECT @i = min(idx), @dcount = max(idx) FROM @DaysList;
DECLARE @j int;
DECLARE @tcount int;
SELECT @tcount = max(idx) FROM @StartTimeList;

DECLARE @DayVar nchar(10);
DECLARE @StartTimeVar time(7);

WHILE @i <= @dcount
BEGIN
    SELECT @j = min(idx) FROM @StartTimeList;
    WHILE @j <= @tcount
    BEGIN
        Print '@i=' + CAST(@i as varchar) + ',@dcount=' + CAST(@dcount as varchar) + ',@j=' + CAST(@j as varchar) + ',@tcount=' + CAST(@tcount as varchar);
        SELECT @DayVar = days FROM @DaysList WHERE idx=@i;
        SELECT @StartTimeVar = times FROM @StartTimeList WHERE idx=@j;
        INSERT INTO dbo.time (day, start_time, end_time) VALUES (
            @DayVar,
            @StartTimeVar,
            (CASE
                WHEN @DayVar IN ('M','T','W','R','F') THEN
                    dateadd(minute, 170, @StartTimeVar)
                WHEN @DayVar IN ('MW','WF','TR') THEN
                    dateadd(minute, 80, @StartTimeVar)
                WHEN @DayVar IN ('MWF') THEN
                    dateadd(minute, 50, @StartTimeVar)
            END));
        SET @j = @j +1
    END
    SET @i = @i + 1
END