<?php
	//credentials file has username, password and host in dollar
	
	include('credentials.php');
//create pdo	
	try
	{
		$dsn = "mysql:host=" . $host . ";dbname=" . "henrybooks";
		$pdo = new PDO($dsn, $username, $password);
	}
	catch (PDOexception $e)
	{
		echo "Connection to database failed: " . $e->getMessage();
	}
?>

<head>
	<p>List's each book title, the name of the branch and the number of copies on hand
in order of Branch name and within that of Title. Display's this in a table.</p>

	<!-- link to go to 2nd question -->
	<a href="http://students.cs.niu.edu/~z1697740/question2.php">2nd Question</a>
</head>
	<h1>Book Availability</h1>

<?php
	
	// Setup the SQL query.

	
	// This statement will collect all of the info we need 
	// for this page in one go
	
	$sql = "SELECT BranchName, Title, OnHand FROM Inventory " .
		       "JOIN Book ON Book.BookCode = Inventory.BookCode " .
	           "JOIN Branch ON Branch.BranchNum = Inventory.BranchNum " .
	       "ORDER BY BranchName, Title;";
	
	$query = $pdo->query($sql);
	
	//webpage potion
	
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

?>

<footer>
	<div style="text-align: center">
		Hasnain Attarwala
		<br/>
		Section 3
	</div>
</footer>