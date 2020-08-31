<head>
	<h2>Look up publisher's and extra credit</h2>
	<p>List that shows the publisher's names and a button. When the user chooses a publisher name and clicks the button the page display's the titles of the books that publisher</p>
	<hr/>
</head>

<form action="question2.php" method="post">
	<b>Publisher:</b>
	<br/>
	<select name="publisher">
	<?php
		// Initialize the $pdo variable.
		include("credentials.php");
		try
		{
		$dsn = "mysql:host=" . $host . ";dbname=" . "henrybooks";
		$pdo = new PDO($dsn, $username, $password);
		}
		catch (PDOexception $e)
		{
		echo "Connection to database failed: " . $e->getMessage();
		}
		
		// Query the publisher names.
		$publishers = $pdo->query("SELECT PublisherCode, PublisherName FROM Publisher;");
		$selected = null;
		
		if (array_key_exists("publisher", $_POST))
			$selected = $_POST["publisher"];
		
		// Insert each publisher name into the dropdown.
		while ($row = $publishers->fetch())
		{
			$pCode = $row["PublisherCode"];
			$pName = $row["PublisherName"];
			
			echo("\t\t<option value=$pCode");
			
			// Add a "selected" attribute if this publisher
			// was selected from the form submission.
			if ($selected == $pCode)
				echo(" selected");
			
			echo(">$pName</option>\n");
		}
	?>
	</select>
	<br/><br/>
	<input type="submit">
</form>

<hr/>

<?php
	// If the form has been submitted, process the result.
	//if (!empty($_POST["publisher"]))
	{
		$pCode = $_POST["publisher"];
		
		
		// Query the books whose PublisherCode is equal to the submitted publisher code.
		$books = $pdo->query("SELECT Title FROM Book WHERE PublisherCode = \"$pCode\";");
		
		// Begin generating the results.
		echo "<h3>Query Results</h3>\n";
		$noResults = true;
		
		while ($row = $books->fetch())
		{
			if ($noResults)
			{
				$noResults = false;
				echo "<ul>\n";
			}
			
			$title = $row["Title"];
			echo "\t<li>$title</li>\n";
		}
		
		// If there were no results, report it to the user. Otherwise close the list.
		echo($noResults ? "<i>None found</i>" : "</ul>\n");
	}
?>

<head>
	<br/><br/><br/>
	<h2>Extra credit: </h2>
	<p>List each branch location, the number of employees and the number of books on hand</p>
	<hr/>
</head>
<?php
	$sql = "SELECT BranchLocation, NumEmployees, SUM(OnHAND) FROM Inventory " .
		"JOIN Branch ON Inventory.BranchNum = Branch.BranchNum " .
	       "GROUP BY BranchLocation;";
	
	$query = $pdo->query($sql);

	
	//webpage potion
	
	// Track what branch we iterated over last.
	// If this changes, we will start a new table.
	$lastBranch = null;
	
	// Writes out a prettified table row into the HTML output.
	// row should be a row object returned from a call to $query->fetch()
	// columnType specifies the tag that will be used for columns in this row.
	function writeRow($NumEmployees, $SUM,  $columnType)
	{
		$open = "\t\t<" . $columnType . '>';
		$close = "</" . $columnType . ">\n";
		
		echo "\t<tr>\n";
		echo $open . $NumEmployees . $close;
		echo $open . $SUM . $close;
		echo "\t</tr>\n";
	}
	
	// Writes some tags to the HTML output to close a table.
	// The tags are only written if lastBranch isn't null.
	function closeTable($lastBranch)
	{
		if ($lastBranch != null)
		{
			echo "\t</tr>\n";
			echo "</table>\n";
		}
	}
	
	// Begin iterating over the query.
	while ($row = $query->fetch())
	{
		$branch = $row["BranchLocation"];
		
		if ($branch != $lastBranch)
		{
			if ($lastBranch != null)
				echo "</table>\n";

			// Write the new branch header.
			echo "<h2>" . $branch . " &nbsp; -Location " . "</h2>\n";
			
			// Open the table and its header row.
			echo "<table>\n";
			writeRow("Num of employees, ", "Available Books", "th");
			
			// Mark the last branch as our current branch.
			$lastBranch = $branch;
		}

		$NumEmployees = $row["NumEmployees"];
		$SUM = $row["SUM(OnHAND)"];
		
		writeRow($NumEmployees, $SUM, "td");
	}
	
	// Close the last table since the loop terminated before we could.
	if ($lastBranch != null)
		echo "</table>\n";
	
?>

<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer>