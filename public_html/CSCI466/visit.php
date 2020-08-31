<head>
	<h2>Add Visits</h2>
	<p> A page that adds a visit for a particular dog. A drop down(selection) list of the dogs and text box that allows the user to enter a date.  If left blank, tryint to make it current date.
	</p>
	<hr/>
</head>
<form action="visit.php" method="post">
	Pick a Dog by ID num:
	<select name="dropper">
		<?php
			// Initialize the $pdo variable.
			include("credentials.php");
			try
			{
			$dsn = "mysql:host=" . $host . ";dbname=" . "z1697740";
			$pdo = new PDO($dsn, $username, $password);
			}
			catch (PDOexception $e)
			{
			echo "Connection to database failed: " . $e->getMessage();
			}
			
			$ids = $pdo->query("SELECT dogid FROM Dogs;");
			$selected = null;
				
			if (array_key_exists("dropper", $_POST))
				$selected = $_POST["dropper"];
			
			// Insert each droppdown name into the dropdown.
			while ($row = $ids->fetch())     //echo "<br><option>" .$row['PublisherName']."</option>";
			{
				$dogyid = $row["dogid"];
				
				//puts values <option value=2>
				echo("\t\t<option value=$dogyid");
				echo(">$dogyid</option>\n");
			}
		?>
	</select>
	
	Pick a date: 
		<input type="date" name="rawdate" value="rawdate"/>
	<input type="submit" value = "Visit Dog" name="bttn" value =""/>  
</form>

<hr/>

<?php  
	// If the form has been submitted, process the result.
	if (isset($_POST["bttn"]))
	{
		echo"Adding Dog # ";
		echo "$selected";
//		echo gettype($selected), "\n";

		$number = (int)$selected;
//		echo gettype($number), "\n";

		$sq = "INSERT INTO Visits(dogyid) VALUES ('$number')";;	
		$stm= $pdo->prepare($sq);
		$stm->execute();
		
	//	$stmt= $pdo->prepare($sql);
		//$stmt->execute($data);
		
		if($stm)
		{
			echo " to visited table";
		}
		else
		{
			echo "<br/> Couldn't add, plz make sure all fields added properly<br/>";
		} 
	} 
/* 

<head>
	<br/><br/><br/>
	<h2> Helper page a list of all the visits </h2>
	<p></p>
	<hr/>
</head>
<?php /*
	$sql = "SELECT name, vid FROM Visits" .
		"JOIN Dogs ON Dogs.dogid = Visits.dogyid " .
	       "GROUP BY dogyid;";

	$query = $pdo->query($sql);


	$lastDog = null;
			
			function writeRow($name, $vid, $columnType)
			{
			$open = "\t\t<" . $columnType . '>';
			$close = "</" . $columnType . ">\n";
		
			echo "\t<tr>\n";
			echo $open . $name . $close;
			echo $open . $vid . $close;
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
			writeRow("Name", "Vid", "th");
			// Begin iterating over the query.
			while ($row = $query->fetch())
			{
				$name = $row["name"];
				$vid = $row["vid"]; 
								
				if ($dogid != $lastDog)
				{
					/*
					if ($lastDog != null)
						echo "</table>\n"; */

				//	// Write the new branch header.
				//	echo "<h2>" . $branch . "</h2>\n";
					
	
				//	$lastDog = $dogid;
				//}
				
			//	writeRow($name, $vid, "td");
		//	}
			
			// Close the last table since the loop terminated before we could.
			//if ($lastDog != null)
				//echo "</table>\n";
	
?>
	
	</form>



<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer></html>
