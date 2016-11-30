<?php
include "backend/checkloggedin.php";
if(isset($_POST['submit'])){
    include "backend/config.php";
    $message = $_POST['message'];
    if($message == "")
    {
        die("<script type='text/javascript'>alert('pls no empty inserts m8'); window.location = \"../chat.php\";</script>");
    }
    $userId= $_SESSION['Id'];
    $sentfrom = $_SESSION['userLoggedin'];
    $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES ('$sentfrom','$message')";
    $result = mysqli_query($db,$mySqlQuery);
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
            <div id="messagediv" style="height: 77vh;width: 100%; display: inline-block;overflow-y: scroll;" class="form-group">
                    <script src="http://code.jquery.com/jquery-latest.js"></script>
                    <script>
                        $(document).ready(function(){
                            setInterval(function() {
                                $("#messagediv").load("backend/getmessages.php");
                            }, 2000);
                        });
                    </script>
            </div>
            <div class="form-group">
                <input name="message" class="form-control" placeholder="Enter your message">
            </div>
            <button type="submit" name="submit" class="btn btn-primary">Send message</button>
        </form>
        <?php include"logout.php"?>
    </div>
</div>​

</body>
</html>