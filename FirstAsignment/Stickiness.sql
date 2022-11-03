SELECT DAU/WAU as "Stickiness(Weekly)", DAU/MAU as "Stickiness(Monthly)"
FROM 
(
SELECT count(distinct UserID) as "DAU"
FROM Users
WHERE Date > now() - INTERVAL 1 DAY
) AS DAU

JOIN
(
SELECT count(distinct UserID) as "WAU"
FROM Users
WHERE Date > now() - INTERVAL 7 DAY
) AS WAU

JOIN
(
SELECT COUNT(DISTINCT UserID) as "MAU"
FROM Users
WHERE Date > NOW() - INTERVAL 1 MONTH
) AS MAU
