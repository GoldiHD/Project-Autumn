<?php
if (isset($_POST['logout'])) {

    $mySqlQuery = "INSERT INTO `mainlobby` (sentfrom,message)VALUES (?,?)";
    $stmt = $db->prepare($mySqlQuery);
    $_SERVER =  "SERVER";
    $message = $_SESSION['userLoggedin'] . " Has logged out.";
    $stmt -> bind_param("ss",$_SERVER,$message);
    $stmt ->execute();
    $stmt -> close();
    session_destroy();
    die(header("Location: ./index.php"));
}
?>
<form action="" method="post" class="logout">
    <input class="btn btn-danger" type="submit" name="logout" id="submit" value="Log ud">
</form>
