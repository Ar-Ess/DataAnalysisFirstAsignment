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
    $name = $_POST["name"];
    $country = $_POST["country"];
    $date = $_POST["u_date"];
    
    // Insert data from users
    $sql = "INSERT INTO Users (Name,Country,Date)
            VALUES('$name','$country','$date')";
    $result = mysqli_query($connection,$sql);

    $last_id = $connection->insert_id;
    

    //Grab data from sessions
    $sdate = $_POST["s_date"];
    $state = $_POST["state"];

    $s_sql = "INSERT INTO Sessions (Date,State)
            VALUES('$sdate','$state')";
    $s_result = mysqli_query($connection,$s_sql);

    echo $last_id;

?>