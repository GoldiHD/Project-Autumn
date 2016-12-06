<?php
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}
if($_SESSION['loggedin'] == true){
    include "config.php";
    $usr = $_SESSION['userLoggedin'];
    $email = $_SESSION['userEmail'];
    $mySqlQuery = "SELECT * FROM `users` WHERE `username` = '$usr' OR `email` = '$email'";
    $result = mysqli_query($db,$mySqlQuery);
    if($result->num_rows == 0) {
        session_destroy();
        die(header("Location: ../index.php"));
    }

}
elseif($_SESSION['loggedin'] == false)
{
    session_destroy();
    die(header("Location: ../index.php"));
}
?>