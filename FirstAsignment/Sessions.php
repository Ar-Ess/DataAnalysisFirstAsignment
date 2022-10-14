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
    
    //Grab data from sessions
    $sdate = $_POST["s_date"];
    $state = $_POST["state"];
    $id = $_POST["s_id"]

     //Insert data sessions into sessions table 
    $s_sql = "INSERT INTO Sessions (Date,State,ID)
            VALUES('$sdate','$state','$id')";
    $s_result = mysqli_query($connection,$s_sql);

?>