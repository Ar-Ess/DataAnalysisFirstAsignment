<?php

    $host="localhost";
    $database="jordiea3";
    $user="jordiea3";
    $password="NcpbTyykNZ";
    $error="Cant connect";


    $connection = mysqli_connect($host,$user,$password);
    mysqli_select_db($connection,$database) or die("Unable connect to database");
    //Check connection

    if(!$connection)
    {
        die("no connection" . mysqli_connect_error());
    }
    // Grab data from users 
    $date = $_POST["b_date"];
    $id = $_POST["b_id"];
    $playerID = $_POST["p_id"];
    
    // Insert data into users table
    $sql = "INSERT INTO Transactions (Date,ItemID,UserID)
            VALUES('$date','$id','$playerID')";
    $result = mysqli_query($connection,$sql);

?>