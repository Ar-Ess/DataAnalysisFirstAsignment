SELECT sum(price) as Revenue, count(distinct UserID) as Users, sum(price) / count(distinct UserID) as ARPU
FROM ItemsPrice
JOIN Transactions
ON 	item_id = ItemID
JOIN Sessions
ON  Transactions.SessionID = Sessions.SessionID
RIGHT JOIN Users
ON UserID = ID