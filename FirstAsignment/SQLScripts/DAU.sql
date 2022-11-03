SELECT distinct date(StartDate) as "DAY",
 count(distinct ID) as "DAU"
FROM Sessions
group by date(StartDate)
