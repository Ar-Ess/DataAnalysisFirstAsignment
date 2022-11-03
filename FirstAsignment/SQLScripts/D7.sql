SELECT count(distinct UserID) as TotalUsers, count(distinct ID) / count(distinct UserID) as D7
FROM Sessions
right JOIN Users
ON UserID = ID AND DATE(StartDate - interval 7 day) = date(Date)