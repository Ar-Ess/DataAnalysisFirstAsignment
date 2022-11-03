SELECT count(distinct SessionID) as "Nº Sessions" , (TIMESTAMPDIFF(minute, StartDate, EndDate)) as "Length (minutes)"
FROM Users,Sessions
WHERE UserID = ID
