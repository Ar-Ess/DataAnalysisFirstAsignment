SELECT distinct date(Dates), count(distinct Sessions.ID)
FROM Dates
left JOIN Sessions
on date(StartDate) <= date(Dates.Dates) and
date(StartDate) > date(Dates.Dates) - interval 30 day
where date(Dates) = date(StartDate)
order by Dates
 