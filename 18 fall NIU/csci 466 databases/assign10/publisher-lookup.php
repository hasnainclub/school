<head>
	<link rel="stylesheet" href="styles.css">
	<h2>Publisher Lookup</h2>
	<p>Select a publisher and press Submit to view a list of books published by that publisher!</p>
	<hr/>
</head>

<form action="publisher-lookup.php" method="post">
	<b>Publisher:</b>
	<br/>
	<select name="publisher">
	<?php
		// Initialize the $pdo variable.
		include("database.php");
		
		// Query the publisher names.
		$publishers = $pdo->query("SELECT PublisherCode, PublisherName FROM Publisher;");
		$selected = null;
		
		if (array_key_exists("publisher", $_POST))
			$selected = $_POST["publisher"];
		
		// Insert each publisher name into the dropdown.
		while ($row = $publishers->fetch())
		{
			$pubCode = $row["PublisherCode"];
			$pubName = $row["PublisherName"];
			
			echo("\t\t<option value=$pubCode");
			
			// Add a "selected" attribute if this publisher
			// was selected from the form submission.
			if ($selected == $pubCode)
				echo(" selected");
			
			echo(">$pubName</option>\n");
		}
	?>
	</select>
	<br/><br/>
	<input type="submit">
</form>

<hr/>

<?php
	// If the form has been submitted, process the result.
	if (!empty($_POST["publisher"]))
	{
		$pubCode = $_POST["publisher"];
		
		// Make sure the publisher code is "somewhat safe"
		// Since they are only two characters, we can make that a constraint,
		// and there isn't really any SQL injection you can do with two characters.
		
		if (strlen($pubCode) != 2)
		{
			echo("ERROR: Submitted publisher was invalid!\n");
			return;
		}
		
		// Query the books whose PublisherCode is equal to the submitted publisher code.
		$books = $pdo->query("SELECT Title FROM Book WHERE PublisherCode = \"$pubCode\";");
		
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
		echo($noResults ? "<i>No books were found under this publisher!</i>" : "</ul>\n");
	}
	
	// Add the footer.
	include "footer.html"
?>