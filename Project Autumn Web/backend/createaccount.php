<?php
if (isset($_POST['submit']))
{
    $username = $_POST['user_name'];
    $email = $_POST['user_email'];
    $emailRe = $_POST['user_email_re'];
    $password = $_POST['user_pass'];
    $passwordRe = $_POST['user_pass_re'];
    if(strlen($username) <= 6)
    {
        die("<script type='text/javascript'>alert('Det indtastede brugernavn er under 7 tegn'); window.location = \"../register.php\";</script>");
    }
    if($email != $emailRe)
    {
        die("<script type='text/javascript'>alert('De indtastede E-mails er ikke ens.'); window.location = \"../register.php\";</script>");
    }
    if($password != $passwordRe || strlen($password) <= 6)
    {
        die("<script type='text/javascript'>alert('De indtastede Kodeorder er ikke ens eller er under 7 karaktere lange.'); window.location = \"../register.php\";</script>");
    }
    include 'config.php';
    $username = mysqli_real_escape_string($db,$username);
    $email = mysqli_real_escape_string($db,$email);
    $mySqlQuery = "SELECT * FROM `users` WHERE `username` = '$username' OR `email` = '$email'";
    $result = mysqli_query($db,$mySqlQuery);
    $row = mysqli_fetch_array( $result, MYSQLI_ASSOC );
    if($row['user_name'] == $username || $row['user_email'] == $email)
    {
        die("<script type='text/javascript'>alert('Der findes allerede en konto med samme navn eller E-mail.'); window.location = \"../register.php\";</script>");
    }
   $passwordHashed =  password_hash($password, PASSWORD_DEFAULT);
   $passwordHashed = mysqli_real_escape_string($db,$passwordHashed);
    $mySqlQuery = "INSERT INTO `users` (username,email,password)VALUES ('$username','$email','$passwordHashed')";
    mysqli_query($db,$mySqlQuery);
    die("<script type='text/javascript'>alert('Kontoen blev oprettet.'); window.location = \"../index.php\";</script>");
}