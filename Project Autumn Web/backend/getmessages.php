<?php
include "checkloggedin.php";
include "config.php";
$mySqlQuery = "SELECT * FROM `mainlobby`";
$result = mysqli_query($db,$mySqlQuery);

function make_links_clickable($text){
    return preg_replace('@(https?://([-\w\.]+[-\w])+(:\d+)?(/([\w/_\.#-]*(\?\S+)?[^\.\s])?)?)@', '<a href="$1" target="_blank">$1</a>', $text);
}
while ($row = mysqli_fetch_array( $result, MYSQLI_ASSOC )){
    echo $time = date("H:i:s",strtotime($row['currenttime'])) . " - ";
    echo $row['sentfrom'] . ": ";
    echo make_links_clickable($row['message']);
    echo "<br>";
}
echo "<script type='text/javascript'>var objDiv = document.getElementById(\"messagediv\");
objDiv.scrollTop = objDiv.scrollHeight;</script>";