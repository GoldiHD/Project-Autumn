<?php
include "backend/checkloggedin.php";
if(isset($_POST['submit'])){
    include "backend/config.php";
    include "backend/MysqliDb.php";
    $message = $_POST['message'];
    $donger = "༼つ ◕_◕ ༽つ";
    $dongerbill = @'[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅]';
    $shotsfired = "┌( ͝° ͜ʖ͡°)=ε/̵͇̿̿/’̿’̿ ̿ ";
    $why = "ლ( `Д’ ლ)";
    $fight = "(ง’̀-‘́)ง";
    $message = str_ireplace("!d",$donger,$message);
    $message = str_ireplace("!moneh",$dongerbill,$message);
    $message = str_ireplace("!shotsfired",$shotsfired,$message);
    $message = str_ireplace("!why",$why,$message);
    $message = str_ireplace("!fightme",$fight,$message);
   // $message = mysqli_escape_string($db,$_POST['message']);
    if($message == "")
    {
        die("<script type='text/javascript'>alert('pls no empty inserts m8'); window.location = \"../chat.php\";</script>");
    }
    $userId= $_SESSION['Id'];
    $sentfrom = $_SESSION['userLoggedin'];
    $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES ('$sentfrom','$message')";
    $result = mysqli_query($db,$mySqlQuery);
    $_SESSION['lastMessageId'] = mysqli_insert_id($db);
    if($message == "!edif")
    {
        die("<script type='text/javascript'>window.location = \"http://www.steffench.dk/erdetikkefredag.php\";</script>");
    }
    elseif (strpos($message, '!ban') !== false && $_SESSION['userPrivilege'] == 1) {
        $null = null;
        $message = str_ireplace("!ban ",$null,$message);
        $mySqlQuery = "DELETE FROM users WHERE username = '$message'";
        $result = mysqli_query($db,$mySqlQuery);
        $mySqlQuery = "DELETE FROM mainlobby WHERE sentfrom = '$message'";
        $result = mysqli_query($db,$mySqlQuery);
        $banmsg = $message . " Was banned!";
        $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES ('SERVER','$banmsg')";
        $result = mysqli_query($db,$mySqlQuery);
        $_SESSION['lastMessageId'] = mysqli_insert_id($db);
    }
}
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Chat - Chatter</title>
    <link href="https://fonts.googleapis.com/css?family=Lato" rel="stylesheet">
    <link rel="stylesheet" href="./style/bootstrap.css">
    <style>
        .center {
            position: absolute;
            width: 100%;
            height: 100%;
        }​
    </style>
</head>
<body style="font-family: 'Lato', sans-serif;font-size: medium;margin: 1vh;overflow: hidden">
<div class='fullscreenDiv'>
    <div class="center">
        <form action="" method="post">
            <div id="messagediv" style="height: 77vh;width: 100%; display: inline-block;overflow-y: scroll;word-break: break-all;overflow-x: hidden" class="form-group">
                    <script src="http://code.jquery.com/jquery-latest.js"></script>
                    <script>
                        $(document).ready(function(){
                            setInterval(function() {
                                $("#messagediv").load("backend/getmessages.php");
                            }, 100);
                        });
                    </script>
            </div>
            <div class="form-group">
                <input name="message" class="form-control" autofocus placeholder="Enter your message">
            </div>
            <button type="submit" name="submit" class="btn btn-primary">Send message</button>
        </form>
        <?php include"logout.php"?>
    </div>
</div>​

</body>
</html>