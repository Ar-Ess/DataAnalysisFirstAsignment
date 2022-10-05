<?php

$servername = "localhost";

// user info
$name = $_POST["userName"];
$country = $_POST["country"];
$date = $_POST["date"];

//Check connection
if($conn->connect_error)
{
    die("Connection failed: " . $conn->connect_error);
}
echo "Connected succesfully";

$sql = "SELECT name FROM names where name = " . $conn->connect_error);


$result = $conn->query($sql);