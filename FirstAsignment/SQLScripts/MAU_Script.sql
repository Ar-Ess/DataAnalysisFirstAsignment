SELECT date(Date) as Day, COUNT(DISTINCT player_id) as MAU
FROM yeardate2020
LEFT JOIN sessions
ON sessions.start BETWEEN DATE_ADD(Date, INTERVAL -30 day) AND Date
GROUP BY Date