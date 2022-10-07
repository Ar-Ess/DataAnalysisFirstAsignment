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

    $name = $_POST["name"];
    $country = $_POST["country"];
    $date = $_POST["date"];
    
    $sql = "INSERT INTO Users (Name,Country,Date)
            VALUES('$name','$country','$date')";
    $result = mysqli_query($connection,$sql);

    $last_id = $connection->insert_id;


    echo $last_id;

?>