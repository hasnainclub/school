<?php
echo "<head><title>Books & Branches</title></head>";

$username = "z1831554";
$password = "1992May14";
$host = "courses";
$database ="henrybooks";
$connection = new mysqli("$host", "$username", "$password", "$database");
$sql = "SELECT Inventory.OnHand, Branch.BranchName, Book.Title FROM ((Inventory INNER JOIN Branch ON Inventory.BranchNum = Branch.BranchNum)INNER JOIN Book ON Inventory.BookCode = Book.BookCode);";
$result = $connection->query($sql);

echo "<table border='0' cellspacing='2' cellpadding='2'><tr><td>OnHand</td><td>Branch</td><td>Title</td></tr>";

while($row = mysqli_fetch_assoc($result))
{ $f1=$row['OnHand'];
  $f2=$row['BranchName'];
  $f3=$row['Title'];
  echo "<tr><td>";
  echo $f1;
  echo "</td>";
  echo "<td>";
  echo $f2;
  echo "</td><td>";
  echo $f3;
  echo "</td></tr>"; }

echo "</table>";
?>

<html>
<br/>
<a href="publisherbooks.php" target="_blank">Books & Publisher</a>
<br/>
<a href="booktype.php" target="_blank">Genre of Books</a>
<center><b>Emily Ducatte - Section 3</b></center>
</html>

