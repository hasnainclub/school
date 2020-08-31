<head>
	<h2>Remove Visits</h2>
	<p> A page that removes visit's for a particular dog.
	</p>
	<hr/>
</head>
<form action="delete.php" method="post">
	Pick a Dog by visit num:
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
			
			$ids = $pdo->query("SELECT vid FROM Visits ORDER BY vid; ");
			$selected = null;
				
			if (array_key_exists("dropper", $_POST))
				$selected = $_POST["dropper"];
			
			// Insert each droppdown name into the dropdown.
			while ($row = $ids->fetch())     //echo "<br><option>" .$row['PublisherName']."</option>";
			{
				$vid = $row["vid"];
				
				//puts values <option value=2>
				echo("\t\t<option value=$vid");
				echo(">$vid</option>\n");
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
//		echo gettype($number), "\n";

	//	$count = $pdo->exec("DELETE FROM Visits WHERE vid = $number";);

		$sq = ("DELETE FROM Visits WHERE vid = '$number'; ");
		$stm= $pdo->query($sq);
		//$stm->execute();
		if($stm)
		{
			echo " --delete successful";
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
