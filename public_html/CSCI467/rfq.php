<?php
		
		// Initialize the $pdo variable.
		include("credentials.php");
		try
		{
		$dsn = "mysql:host=" . $host . ";dbname=" . "z1697740";
		$pdo = new PDO($dsn, $username, $password);
		echo "connected to server";
		
		}
		catch (PDOexception $e)
		{
		echo "Connection to database failed: " . $e->getMessage();
		}
?>
<html>
<html><head><br/>

	<h2>Develop interactive prototypes for the following input screen(s) based on your low-   fidelity prototypes that you completed in 
	assignment #3. 
</h2>
	<p> For this option, you will need to create the customer account and the inventory part tables and populate them with sample 
	data in order for you to have the required objects with data to be used when creating a new RFQ. Remember that an RFQ object a container 
	object. You will need to create at least 15 RFQ objects to show on your RFQ status report – SEE PART-2 BELOW.
1.	Create New RFQ (Input screen design for an Auto-Quote Customer Account type only.) Note that an RFQ must have one or more detail lines, 
each line represents part information and how much (i.e. order quantity) to be purchased by the customer. The structure is very similar to a 
Purchase Order object that we saw a sample during our class discussions. – 100 points  </p>
</head>

<body>
	<form action="dog.php" method="post">
	Dog Breed: <input type="text" name="breed" value="Testbreed" /><br/><br/>
	Dog Name: <input type="text" name="name" value="testName"/><br/><br/>
	<input type="submit" value = "Add dog" name="bttn" />   
</body>

<?php		

		
?>
	
	</form>



<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer></html>