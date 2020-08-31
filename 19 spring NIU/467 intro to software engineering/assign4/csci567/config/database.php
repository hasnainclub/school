<?php
	//////////////////////////////////////////////////////////////
	// PDO Configuration
	//////////////////////////////////////////////////////////////
	
	$host = "courses";
	$username = "cs56714";
	$password = "hasnain12";
	
	//////////////////////////////////////////////////////////////
	// Initialize PDO
	//////////////////////////////////////////////////////////////
	
	try
	{
		$dsn = "mysql:host=$host;dbname=$username";
		$pdo = new PDO($dsn, $username, $password);
		
		$pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	}
	catch (PDOexception $e)
	{
		echo "Connection to database failed: " . $e->getMessage();
	}
?>