<?php
if (session_status() == PHP_SESSION_NONE)
{
    session_start();
}
if($_SESSION['loggedin'] == true)
{
    include "config.php";
    $usr = $_SESSION['userLoggedin'];
    if($usr == "" || $usr == " :" || $usr == ""){
        session_destroy();
        die(header("Location: ../index.php"));
    }
    $email = $_SESSION['userEmail'];
    $mySqlQuery = "SELECT * FROM `users` WHERE `username` = ? OR `email` = ?";
    $stmt = $db->prepare($mySqlQuery);
    $stmt -> bind_param("ss", $usr,$email);
    $stmt ->execute();
    $result = $stmt->get_result();
    if($result->num_rows == 0)
    {
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