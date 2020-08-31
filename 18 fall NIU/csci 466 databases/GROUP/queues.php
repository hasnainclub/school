<html>
<head>
<title>Song Queues</title>
	<style>
            body {
                background-color: #9c9d9e;
            }
	    table {
		font-size: 20px;
                color: #37495b;
                background-color: #baccdd;
                border: 3px solid black;
		width: 75%;
                text-align: center;
	    }
            th {
		border-bottom: 2px solid black;
                cursor: pointer;
	    }
            tr:nth-child(even) {
                background-color: #95a9bc;
	    }
            tr:hover td {
                background: #b9d8f7;
            }
	    td {
		text-align: center;
	    }
            div {
                font-size: 20px;
            }
        </style></style>
</head> 
<body text="#283f56">
<h2>Free Queue</h2>
<?php
try { // if something goes wrong, an exception is thrown
	$dsn = "mysql:host=courses;dbname=z1779194";
	$userID='z1779194';
	$password='1991May01';
	$pdo = new PDO($dsn, $userID, $password);
}
catch(PDOexception $e) { // 
	echo "Connection to database failed: " . $e->getMessage();
}
$sql1=("SELECT *
	FROM FreeQueue
	INNER JOIN KaraokeTrack ON 						 		FreeQueue.trackId=KaraokeTrack.trackId
	INNER JOIN User ON FreeQueue.userId=User.userId
	INNER JOIN Song ON KaraokeTrack.songId=Song.songId
	WHERE isPlayed!='yes'
	");
$stmt=$pdo->prepare($sql1);
$stmt->execute();
$result=$stmt->setFetchMode(PDO::FETCH_ASSOC);
echo "<form action='' method='GET'>";
echo "<table>";
echo "<tr><th>Song Name</th><th>Track ID</th><th>Artist 	Name</th><th>Requested By</th><th>Time Requested</th><th>Played</th></tr>";
foreach($stmt->fetchAll() as $rows=>$row) {
    echo"<tr><td>".$row['title']."</td><td>".$row['trackId']."</td><td>".$row['artist']."</td><td>".$row['fname']." ".$row['lname']."</td><td>".$row['time']."</td><td><input type='radio' name='radio1' value=".	$row['queueId']."></input></td></tr>";
}
echo "</table><br>";
echo "<input type='submit' value='Update Free Queue' 	name='submit1'></input>"; 
if(isset($_GET['submit1'])) {
	if(isset($_GET['radio1'])) {
		$fVal=$_GET['radio1'];
		$sqlf=("UPDATE FreeQueue SET isPlayed='yes' WHERE 			queueId=$fVal");
		$stmt=$pdo->prepare($sqlf);
		$stmt->execute();
		header("Refresh:0; url=queues.php");
     	}
}
echo "</form>";
echo "<h2>Paid Queue</h2>";
$sql2=("SELECT *
	FROM PaidQueue
	INNER JOIN KaraokeTrack ON 						 		PaidQueue.trackId=KaraokeTrack.trackId
	INNER JOIN User ON PaidQueue.userId=User.userId
	INNER JOIN Song ON KaraokeTrack.songId=Song.songId
	WHERE isPlayed!='yes'
	");
if(isset($_GET['sort'])) {
	if($_GET['sort']=='paid') {
		$sql2.=" ORDER BY payAmount DESC";
	}
	else $sql2.=" ORDER BY time";
}
$stmt=$pdo->prepare($sql2);
$stmt->execute();
$result=$stmt->setFetchMode(PDO::FETCH_ASSOC);
echo "<form action='' method=GET>";
echo "<table>";
echo "<tr><th>Song Name</th><th>Track ID</th><th>Artist 	Name</th><th>Requested by</th><th><a href='queues.php?	sort=time'>Time Requested</a></th><th><a href='queues.php?	sort=paid'>Amount Paid</a></th><th>	Played</th></tr>";
foreach($stmt->fetchAll() as $rows=>$row) {
    echo"<tr><td>".$row['title']."</td><td>".	$row['trackId']."</td><td>".$row['artist']."</td><td>".	$row['fname']." ".$row['lname']."</td><td>".	$row['time']."</td><td>".$row['payAmount']."</td><td>	<input type='radio' name='radio2' value=".	$row['paidId']."></input></td></tr>";
}
echo "</table><br>";
echo "<input type='submit' value='Update Paid Queue' 	name='submit2'></input>"; 
echo "</form>";
if(isset($_GET['submit2'])) {
	if(isset($_GET['radio2'])) {
		echo "selected: ".$_GET['radio2'];
		$pVal=$_GET['radio2'];
		$sqlp=("UPDATE PaidQueue SET isPlayed='yes' WHERE 			paidId=$pVal");
		$stmt=$pdo->prepare($sqlp);
		$stmt->execute();
		header("Refresh:0; url=queues.php");
     	}
}
?>
</body>
</html>