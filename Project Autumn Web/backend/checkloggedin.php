<?php
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}
if($_SESSION['loggedin'] == false)
{
    session_destroy();
    die(header("Location: ../index.php"));
}
?>