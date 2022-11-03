SELECT distinct date(StartDate) as "DAY",
 count(distinct ID) as "WAU"
FROM Sessions
group by date(StartDate)