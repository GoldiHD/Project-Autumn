<?php
include "checkloggedin.php";
include "config.php";

if(isset($_SESSION['lastMessageId']))
{
    $lastId = $_SESSION['lastMessageId'] - 100;
    $mySqlQuery = "SELECT Id,sentfrom,message,currenttime FROM `mainlobby` WHERE `Id` > ?";
    $stmt = $db->prepare($mySqlQuery);
    $stmt -> bind_param("i", $lastId);
    $stmt ->execute();

}
else
{
    $mySqlQuery = "SELECT Id,sentfrom,message,currenttime FROM `mainlobby`";
    $stmt = $db->prepare($mySqlQuery);
    $stmt ->execute();

}
$result = $stmt->get_result();
$stmt -> close();
function make_links_clickable($text)
{
    return preg_replace('@(https?://([-\w\.]+[-\w])+(:\d+)?(/([\w/_\.#-]*(\?\S+)?[^\.\s])?)?)@', '<a href="$1" target="_blank">$1</a>', $text);
}
while ($row = mysqli_fetch_array( $result, MYSQLI_ASSOC ))
{
    if($row['sentfrom'] == "SERVER"){
        echo "<p style=\"color: #269abc;\">" .  $time = date("H:i:s",strtotime($row['currenttime'])) . " - ";
        echo $row['sentfrom'] . ": ";
        if($row['message'] == "!commands")
        {
            echo " Current commands are: !d, !shotsfired, !why, !fightme, !commands, !edif, !moneh, !glory, !roll, !freestuff, !mymoneh, !ban (if admin)";
            echo "<br> </p>";
        }
        else
        {
            echo make_links_clickable($row['message']);
            echo "<br> </p>";
        }
    }
    else
    {
        echo "<p style=\"color: #d58512;\">" .  $time = date("H:i:s",strtotime($row['currenttime'])) . " - ";
        echo $row['sentfrom'] . ": ";
        if($row['message'] == "!commands")
        {
            echo " Current commands are: !d, !shotsfired, !why, !fightme, !commands, !edif, !salts, !moneh, !glory, !roll, !freestuff, !mymoneh,!autocomplete, !ban (if admin)";
            echo "<br> </p>";
        }
        else
        {
            $test = nl2br($row['message']);
            echo make_links_clickable($test);
            echo "<br> </p>";
        }
    }
}

echo "<script type='text/javascript'>var objDiv = document.getElementById(\"messagediv\");
objDiv.scrollTop = objDiv.scrollHeight;</script>";