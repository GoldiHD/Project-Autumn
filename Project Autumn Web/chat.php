<?php
gc_enable();
include "backend/checkloggedin.php";
if(isset($_POST['submit']))
{
    include "backend/config.php";
    include "backend/MysqliDb.php";
    $message = strip_tags($_POST['message']);
    $donger = "༼つ ◕_◕ ༽つ";
    $dongerbill = @'[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅]';
    $shotsfired = "┌( ͝° ͜ʖ͡°)=ε/̵͇̿̿/’̿’̿ ̿ ";
    $why = "ლ( `Д’ ლ)";
    $fight = "(ง’̀-‘́)ง";
    $glory = "https://www.reddit.com/r/AyyMD/";
    $num = rand(-1, 100);
    $salts =" ( ͡° ͜ʖ ͡°) ( ͡°﹏ ͡°) ( ͡°_ ͡°)";
    $message = str_ireplace("!salts",$salts,$message);
    $message = str_ireplace("!d",$donger,$message);
    $message = str_ireplace("!moneh",$dongerbill,$message);
    $message = str_ireplace("!shotsfired",$shotsfired,$message);
    $message = str_ireplace("!why",$why,$message);
    $message = str_ireplace("!fightme",$fight,$message);
    $message = str_ireplace("!glory",$glory,$message);
    if($num  == -1){
        $message = str_ireplace("!roll","!roll " . $num . "  lel mate just staph already- ",$message);
    }
    elseif($num  < 2){
        $message = str_ireplace("!roll","!roll " . $num . "  LOL y u so bad m9- ",$message);
    }
    elseif($num < 25){
        $message = str_ireplace("!roll","!roll " . $num . "  LOL Must be rigged as fuck- ",$message);
    }
    elseif ($num > 90 && $num < 99){
        $message = str_ireplace("!roll","!roll " . $num . "   Lol M8 too Ez- ",$message);
    }
    elseif ($num > 98){
        $message = str_ireplace("!roll","!roll " . $num . "   Git gut nerds- ",$message);
    }
    else{
        $message = str_ireplace("!roll","!roll " . $num . " - ",$message);
    }
    $message = str_ireplace("!troll","!roll 100 Git gut nerds- ",$message);
    //$message = mysqli_escape_string($db,$message);
    if($message == "" || $message== " ")
    {
        die("<script type='text/javascript'>alert('pls no empty inserts m8'); window.location = \"../chat.php\";</script>");
    }
    if($message == "!autocomplete"){
        $_SESSION['autocom'] = false;
    }
    if($message == "!edif")
    {
        die("<script type='text/javascript'>window.location = \"http://www.steffench.dk/erdetikkefredag.php\";</script>");
    }
    if($message == "!freestuff")
    {
        die("<script type='text/javascript'>window.location = \"https://www.youtube.com/watch?v=dQw4w9WgXcQ\";</script>");
    }
    $userId= $_SESSION['Id'];
    $sentfrom = $_SESSION['userLoggedin'];
    $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES (?,?)";
    $stmt = $db->prepare($mySqlQuery);
    $stmt -> bind_param("ss", $sentfrom,$message);
    $stmt ->execute();
    $stmt -> close();
    //$result = mysqli_query($db,$mySqlQuery);
    $_SESSION['lastMessageId'] = mysqli_insert_id($db);
    if (strpos($message, '!ban') !== false && $_SESSION['userPrivilege'] == 1) {
        $null = null;
        $message = str_ireplace("!ban ",$null,$message);
        $mySqlQuery = "DELETE FROM users WHERE username = ?";
        $stmt = $db->prepare($mySqlQuery);
        $stmt -> bind_param("s", $message);
        $stmt ->execute();
        $stmt -> close();
        //$result = mysqli_query($db,$mySqlQuery);
        $mySqlQuery = "DELETE FROM mainlobby WHERE sentfrom = ?";
        $stmt = $db->prepare($mySqlQuery);
        $stmt -> bind_param("s",$message);
        $stmt ->execute();
        $stmt -> close();
        // $result = mysqli_query($db,$mySqlQuery);
        $banmsg = $message . " Was banned!";
        $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES ('SERVER',?)";
        $stmt = $db->prepare($mySqlQuery);
        $stmt -> bind_param("s",$banmsg);
        $stmt ->execute();
        $stmt -> close();
        // $result = mysqli_query($db,$mySqlQuery);
        $_SESSION['lastMessageId'] = mysqli_insert_id($db);

    }
    if($message == "!mymoneh"){
        $mySqlQuery = "SELECT dongermoney FROM `users` WHERE `username` = ? OR `email` = ?";
        $stmt = $db->prepare($mySqlQuery);
        $stmt -> bind_param("ss", $_SESSION['userLoggedin'],$_SESSION['userLoggedin']);
        $stmt ->execute();
        $result = $stmt->get_result();
        $stmt ->close();
        $row = mysqli_fetch_array( $result, MYSQLI_ASSOC );
        $messagemoney = $_SESSION['userLoggedin'] . " have " . $row['dongermoney']." " . $dongerbill;
        $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES ('SERVER',?)";
        $stmt = $db->prepare($mySqlQuery);
        $stmt -> bind_param("s",$messagemoney);
        $stmt ->execute();
        $stmt -> close();
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
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</head>
<body style="font-family: 'Comic Sans MS';font-size: medium;margin: 1vh;overflow: hidden; background-color:#2B2E39 ">
<script>
    $(document).ready(function(){
        $('#messagediv').load("backend/getmessages.php");
    });
</script>
<div class='fullscreenDiv'>
    <div class="center">
        <form action="" method="post">
            <div id="messagediv" style="height: 77vh;width: 100%; display: inline-block;overflow-y: scroll;word-break: break-all;overflow-x: hidden" class="form-group">
            </div>
            <div class="form-group">
                <input style="width: 99%; background-color:#2B2E39; color: #d58512" name="message" class="form-control" autofocus <?php if(isset($_SESSION['autocom']) == true){echo "autocomplete=\"off\"";} ?> placeholder="Enter your message">
            </div>
            <button style="margin-bottom:5px"  type="submit" name="submit" class="btn btn-primary" onclick="$('#messagediv').load('backend/getmessages.php')">Send message</button>
        </form>
        <?php include"logout.php"?>
    </div>
</div>​
<script>
    $(document).ready(function(){
        setInterval(function() {
            $('#messagediv').load("backend/getmessages.php");
        }, 5000);
    });
</script>
</body>
</html>