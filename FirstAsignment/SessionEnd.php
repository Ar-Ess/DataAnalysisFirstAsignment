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
    $id = $_POST["s_id"];

     //Insert data sessions into sessions table 
    $s_sql = "UPDATE  Sessions SET EndDate =
            '$sdate' WHERE SessionID = $id" ;

    $s_result = mysqli_query($connection,$s_sql);

?>