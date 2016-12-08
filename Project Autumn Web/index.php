<?php
if (session_status() == PHP_SESSION_NONE) {
	session_start();
	if(isset($_SESSION['loggedin']) == true){
		die(header("Location: ../chat.php"));
	}
} ?>
<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport"
	      content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Login - Chatter</title>

	<link href="https://fonts.googleapis.com/css?family=Roboto+Slab:300,400|Roboto:300,400,700" rel="stylesheet">
	<link rel="stylesheet" href="./style/bootstrap.css">

</head>
<body>
<center style="margin-top: 30vh">
	<section>
		<div>
			<h1 style="color: #3c763d">Login to chat.</h1>
			<form action="backend/loginuser.php" method="post">
				<div class="">
					<div class="col-md-12 center">
						<label for="name_or_email">Username or E-mail</label> <br>
						<input type="text" name="user_nameoremail" id="name_or_email" required>
					</div>
					<div class="col-md-12 center">
						<label for="password">Password</label>
                        <br>
						<input type="password" name="user_pass" id="password" required>
					</div>
					<div class="col-md-12 center">
                        <br>
						<input style="width: 17vh;" class="btn btn-primary" type="submit" name="submit" id="submit" value="Login">
					</div>
				</div>
			</form>

            <a style="margin-top: 1vh" class="btn btn-success" href="register.php"> Register</a>
		</div>
	</section>
</center>
</body>
</html>