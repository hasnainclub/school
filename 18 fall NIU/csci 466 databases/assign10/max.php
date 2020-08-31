<?php
	//////////////////////////////////////////////////////////////
	// PDO Configuration
	//////////////////////////////////////////////////////////////
	
	$host = "courses";
	$database = "henrybooks";
	
	$username = "z1697740";
	$password = "1989Aug01";
	
	//////////////////////////////////////////////////////////////
	// Initialize PDO
	//////////////////////////////////////////////////////////////
	
	try
	{
		$dsn = "mysql:host=" . $host . ";dbname=" . $database;
		$pdo = new PDO($dsn, $username, $password);
	}
	catch (PDOexception $e)
	{
		echo "Connection to database failed: " . $e->getMessage();
	}
?>

<head>
	<link rel="stylesheet" href="/~z1813439/styles.css">
	<h1>Book Availability</h1>
	<p>This page lists the number of copies available for each book in the database by branch.</p>
</head>

<?php
	//////////////////////////////////////////////////////////////
	// Setup the SQL query.
	//////////////////////////////////////////////////////////////
	
	// This statement will collect all of the info we need 
	// for this page in one go!
	
	$sql = "SELECT BranchName, Title, OnHand FROM Inventory " .
		       "JOIN Book ON Book.BookCode = Inventory.BookCode " .
	           "JOIN Branch ON Branch.BranchNum = Inventory.BranchNum " .
	       "ORDER BY BranchName, Title;";
	
	$query = $pdo->query($sql);
	
	//////////////////////////////////////////////////////////////
	// Generate the web page
	//////////////////////////////////////////////////////////////
	
	// Track what branch we iterated over last.
	// If this changes, we will start a new table.
	$lastBranch = null;
	
	// Writes out a prettified table row into the HTML output.
	// row should be a row object returned from a call to $query->fetch()
	// columnType specifies the tag that will be used for columns in this row.
	function writeRow($title, $stock, $columnType)
	{
		$open = "\t\t<" . $columnType . '>';
		$close = "</" . $columnType . ">\n";
		
		echo "\t<tr>\n";
		echo $open . $title . $close;
		echo $open . $stock . $close;
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
		$branch = $row["BranchName"];
		
		if ($branch != $lastBranch)
		{
			if ($lastBranch != null)
				echo "</table>\n";

			// Write the new branch header.
			echo "<h2>" . $branch . "</h2>\n";
			
			// Open the table and its header row.
			echo "<table>\n";
			writeRow("Book Title", "Copies On Hand", "th");
			
			// Mark the last branch as our current branch.
			$lastBranch = $branch;
		}
		
		$title = $row["Title"];
		$stock = $row["OnHand"];
		
		writeRow($title, $stock, "td");
	}
	
	// Close the last table since the loop terminated before we could.
	if ($lastBranch != null)
		echo "</table>\n";
	
	// Done!
?>

<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer>