<?php
    include ("dbconnection.php")

    //Check connection

    if(!$connection)
    {
        die("no connection" . mysqli_connect_error());
    }
    else
    echo "<h1>Connected</h1>"."<br>";

    $name = $_POST["name"];
    $country = $_POST["country"];
    $date = $_POST["date"];
    
    $sql = "INSERT INTO UserData (name,country,date)
            VALUES('".$name."','".$country."','".$date."')";
    $result = mysqli_query($connection,$sql);


    if(!result)
    {
        echo "Wrong";
    }
    else
    echo "Good";

?>