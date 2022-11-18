SELECT date(Date) as Day, COUNT(DISTINCT player_id) as DAU
FROM yeardate2020
LEFT JOIN sessions
ON date(sessions.start) = date(Date)
GROUP BY Date