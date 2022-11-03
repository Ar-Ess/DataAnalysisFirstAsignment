SELECT count(distinct UserID) as TotalUsers, count(distinct ID) / count(distinct UserID) as D3
FROM Sessions
right JOIN Users
ON UserID = ID AND DATE(StartDate - interval 3 day) = date(Date)