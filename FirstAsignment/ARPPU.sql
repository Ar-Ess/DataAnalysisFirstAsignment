SELECT sum(price) as Revenue, count(distinct UserID) as Users, sum(price) / count(distinct UserID) as ARPPU
FROM ItemsPrice
JOIN Transactions
ON 	item_id = ItemID
JOIN Sessions
ON  Transactions.SessionID = Sessions.SessionID
INNER JOIN Users
ON UserID = ID