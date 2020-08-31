<head>
	<h2>FINALLY EXTRA CREDIT!</h2>
	<p> Delete a dog from the database and the visits associated with that dog
	</p>
	<hr/>
</head>
<form action="deleteDog.php" method="post">
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

	<input type="submit" value = "Delete visit!" name="bttn" value =""/>  
</form>

<hr/>

<?php  
	// If the form has been submitted, process the result.
	if (isset($_POST["bttn"]))
	{
		echo"Removing visit num # ";
		echo "$selected";
//		echo gettype($selected), "\n";

		$number = (int)$selected;
		
		//run a join to link the 
		
		$sq = ("DELETE FROM Visits WHERE dogyid = '$number'; ");
		$dd = ("DELETE FROM Dogs WHERE dogid = '$number'; ");
		
		$stm1= $pdo->query($sq);
		$stm2= $pdo->query($dd);
		//$stm->execute();
		if($stm1 && $stm2)
		{
			echo " --delete from both tables done";
		}
		else
		{
			echo "<br/> deletetion failed <br/>";
		} 
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
