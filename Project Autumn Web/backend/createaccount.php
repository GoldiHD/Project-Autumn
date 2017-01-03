<?php
if (isset($_POST['submit']))
{
    $username = strip_tags($_POST['user_name']);
    $email = strip_tags($_POST['user_email']);
    $emailRe = strip_tags($_POST['user_email_re']);
    $password = strip_tags($_POST['user_pass']);
    $passwordRe = strip_tags($_POST['user_pass_re']);
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
    $mySqlQuery = "SELECT * FROM `users` WHERE `username` = ? OR `email` = ?";
    $stmt = $db->prepare($mySqlQuery);
    $stmt -> bind_param("ss", $username,$email);
    $stmt ->execute();
    $result = $stmt->get_result();
    $stmt ->close();
    $row = mysqli_fetch_array( $result, MYSQLI_ASSOC );
    if($row['user_name'] == $username || $row['user_email'] == $email)
    {
        die("<script type='text/javascript'>alert('Der findes allerede en konto med samme navn eller E-mail.'); window.location = \"../register.php\";</script>");
    }
    $passwordHashed =  password_hash($password, PASSWORD_DEFAULT);
    $passwordHashed = mysqli_real_escape_string($db,$passwordHashed);
    $mySqlQuery = "INSERT INTO `users` (username,email,password)VALUES (?,?,?)";
    $stmt = $db->prepare($mySqlQuery);
    $username = preg_replace("/[^A-Za-z0-9?![:space:]]/","fackoff",$username);
    $stmt -> bind_param("sss", $username,$email,$passwordHashed);
    $stmt ->execute();
    $result = $stmt->get_result();
    $stmt ->close();
    die("<script type='text/javascript'>alert('Kontoen blev oprettet.'); window.location = \"../index.php\";</script>");
}