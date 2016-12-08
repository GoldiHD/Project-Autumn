<?php
if (isset($_POST['submit']))
{
    $user_nameormail = strip_tags($_POST['user_nameoremail']);
    $password = strip_tags($_POST['user_pass']);
    include 'config.php';
    $user_nameormail = mysqli_real_escape_string($db,$user_nameormail);
    $password = mysqli_real_escape_string($db,$password);
    if(strlen($user_nameormail) <= 6 || strlen($password) <= 6)
    {
        die("<script type='text/javascript'>alert('Det indtastede brugernavn eller password er kortere end 7 karaktere.'); window.location = \"../index.php\";</script>");
    }
    $mySqlQuery = "SELECT * FROM `users` WHERE `username` = ? OR `email` = ?";
    $stmt = $db->prepare($mySqlQuery);
    $stmt -> bind_param("ss", $user_nameormail,$user_nameormail);
    $stmt ->execute();
    $result = $stmt->get_result();
    $stmt ->close();
    $row = mysqli_fetch_array( $result, MYSQLI_ASSOC );
    $passwordHash = $row['password'];
    if(password_verify($password, $passwordHash) && $user_nameormail = $row['username'] || $user_nameormail = $row['email'])
    {
        session_start();
        $_SESSION['loggedin'] = true;
        $_SESSION['Id'] = $row['Id'];
        $_SESSION['userLoggedin'] = $row['username'];
        $_SESSION['userEmail'] = $row['email'];
        $_SESSION['userPrivilege'] = $row['privileges'];
        $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES (?,?)";
        $stmt = $db->prepare($mySqlQuery);
        $_SERVER =  "SERVER";
        $message = $row['username'] . " Has logged in.";
        $stmt -> bind_param("ss",$_SERVER,$message);
        $stmt ->execute();
        $stmt -> close();
            die(header("Location: ../chat.php"));
    }
    else
    {
        die("<script type='text/javascript'>alert('Brugernavn / E-mail eller Password er forkert.'); window.location = \"../index.php\";</script>");
    }
}
