<?php
echo "<head><title>Publishers & Titles</title></head>";

$username = "z1831554";
$password = "1992May14";
$host = "courses";
$database ="henrybooks";
$connection = new mysqli("$host", "$username", "$password", "$database");
$sql1 = "SELECT PublisherName FROM Publisher;";
$result = $connection->query($sql1);

echo "<select>";

while($row = $result->fetch_assoc())
{ echo "<br><option>" .$row['PublisherName']."</option>"; }
echo "</select>";

$sql2 = "SELECT Book.Title, Publisher.PublisherName FROM Book INNER JOIN Publisher ON Book.PublisherCode = Publisher.PublisherCode;";
$result2 = $connection->query($sql1);

function getTitle($sql2)
{ while($value = $result2->fetch_assoc())
{ echo $row['Title']; } }

echo "</br><button type='button' onclick='getTitle($sql2)'>See books!</button>";
?>
<html>
<br/>
<br/>
<a href="branchtitle.php" target="_blank">Branches and Titles on hand</a>
<br/>
<a href="booktype.php" target="_blank">Genre of Books</a>
<center><b>Emily Ducatte - Section 3</b></center>
</html>
