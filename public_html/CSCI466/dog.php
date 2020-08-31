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
	<!-- link to go to 2nd question -->
	<a href="http://students.cs.niu.edu/~z1697740/CSCI466/visit.php">2nd Question: Add visits</a>
	<hr/>
	
	<p>   </p>
	<!-- link to go to 3rd question -->
	<a href="http://students.cs.niu.edu/~z1697740/CSCI466/delete.php">3rd Question: Delete a Visit</a>
	<hr/>

	<p>   </p>
	<!-- link to go to extra credit-->
	<a href="http://students.cs.niu.edu/~z1697740/CSCI466/deleteDog.php">**Extra Credit**</a>
	<hr/> <br/><br/>
	
	<h2>A web page that allows the user to enter a new dog in our database</h2>
	<p>   </p>
</head>

<body>
	<form action="dog.php" method="post">
	Dog Breed: <input type="text" name="breed" value="Testbreed" /><br/><br/>
	Dog Name: <input type="text" name="name" value="testName"/><br/><br/>
	<input type="submit" value = "Add dog" name="bttn" />   
</body>

<?php		//if submit is pressed
		if (isset($_POST["bttn"])) // Fetching variables of the form which travels in URL
		{
			
				
			$data = [
    			'breed' => $_POST['breed'],
    			'name' => $_POST['name'],];


			$sql = "INSERT INTO Dogs (breed, name) VALUES (:breed, :name);";

			$stmt= $pdo->prepare($sql);
			$stmt->execute($data);
			
			if($stmt)
			{
				echo "<br/> Data Inserted Successfully <br/>";
			}
			else
			{
				echo "<br/> Data Not Inserted <br/>";
			}
			
			//show tables after we insert some stuff
			$selectq = "SELECT * FROM `Dogs`;";
				
			//now create table and run query the above stmtq
			$member = $pdo->query($selectq);
			if (!$member) {
			die($query);
			}
			
			// Track what branch we iterated over last.
			// If this changes, we will start a new table.
			$lastDog = null;
			
			function writeRow($dogid, $breed, $name, $columnType)
			{
			$open = "\t\t<" . $columnType . '>';
			$close = "</" . $columnType . ">\n";
		
			echo "\t<tr>\n";
			echo $open . $dogid . $close;
			echo $open . $breed . $close;
			echo $open . $name . $close;
			echo "\t</tr>\n";
			}
			// Writes some tags to the HTML output to close a table.
			// The tags are only written if lastBranch isn't null.
			function closeTable($lastDog)
			{
			if ($lastDog != null)
			{
				echo "\t</tr>\n";
				echo "</table>\n";
			}
			}
			
			// Open the table and its header row.
				echo "<table>\n";
				
			//write column names
			writeRow("dogid", "breed", "name", "th");
			// Begin iterating over the query.
			while ($row = $member->fetch())
			{
				$dogid = $row["dogid"];
				$breed = $row["breed"]; 
				$name = $row["name"];
				
				if ($dogid != $lastDog)
				{
					/*
					if ($lastDog != null)
						echo "</table>\n"; */

				//	// Write the new branch header.
				//	echo "<h2>" . $branch . "</h2>\n";
					
					// Mark the last branch as our current branch.
					$lastDog = $dogid;
				}
				
				writeRow($dogid, $breed, $name, "td");
			}
			
			// Close the last table since the loop terminated before we could.
			if ($lastDog != null)
				echo "</table>\n";
			
			//create table column name
//			echo <table cellpadding="0" cellspacing="0" border="0">;
//			echo "<tr><th>ID</th><th>BREED</th><th>NAME</th></tr>;
			//display the table tuples, based on the member
/*			echo while($row = $member->fetch()) ;
				{
				echo <tr>;
			    echo <td style='width: 200px;'>;
				echo "$row['dogid']"; 
				echo </td><td style='width: 600px;'>;
				echo "$row['breed']"; 
				echo </td><td>;
				echo "$row['name']"; 
				echo </td>;
				echo </tr>;
				} */
   		}
		else
		{
		echo "<br/> Not added anything yet, or something went wrong <br/>";
		}
		
?>
	
	</form>



<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer></html>