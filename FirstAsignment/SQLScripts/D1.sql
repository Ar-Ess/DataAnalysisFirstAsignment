SELECT count(distinct UserID) as TotalUsers, count(distinct ID) / count(distinct UserID) as D1
FROM Sessions
right JOIN Users
ON UserID = ID AND DATE(StartDate - interval 1 day) = date(Date)