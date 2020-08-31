<?php

echo "<head><title>Authors & Books</title></head>";
echo "<h1>Books and their genres</h1>";

$username = "z1831554";
$password = "1992May14";
$host = "courses";
$database = "henrybooks";
$connection = new mysqli("$host", "$username", "$password", "$database");
$sql = "SELECT Title, Type FROM Book;";
$result = $connection->query($sql);

echo "<dl>";
while($row = $result->fetch_assoc())
{ echo "<dt>" .$row['Title']."</dt>";
  echo "<dd>" .$row['Type']."</dd>"; }
echo "</dl>"

?>
<html>
<br/>
<a href="branchtitle.php" target="_blank">Branches and Titles on hand</a>
<br/>
<a href="publisherbooks.php" target="_blank">Books by Publisher</a>
<center><b>Emily Ducatte - Section 3</b></center>
</html>

