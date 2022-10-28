SELECT count(distinct UserID), date(Date) as Day
FROM Users
WHERE Date > now() - INTERVAL 1 DAY;

