<html>
    <head>
    	<title>Results</title>
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
        </style>
    </head>

    <body text="#283f56">
        <a href="singerSearch.php"><- Back to Search</a>
        <div style="text-align:center">
<?php

include('../assign10/secretSauce.php');
try {
    $dsn = "mysql:host=courses;dbname=z1779194";
    $pdo = new PDO($dsn, $username, $password);
}
catch (PDOexception $e) {
    echo "Connection to database failed...";
}
if (sizeof($_GET) > 0) {
	$search = $_GET['search'];
	$rows = [];
	if ($_GET['searchyBy'] == 'contributor') {
            $pos = strpos($search, " ");
	    if ($pos != 0) {
		$str1 = substr($search, 0, $pos);
		$str2 = substr($search, $pos+1);
		$fname = "%{$str1}%";
		$lname = "%{$str2}%";
		$sql = "SELECT contributorId FROM Contributor WHERE
			fname LIKE :fname AND lname LIKE :lname;";
                $prepared = $pdo->prepare($sql);
		$result = $prepared->execute(array("fname" => $fname, "lname" => $lname));
		$rows = $prepared->fetch(PDO::FETCH_ASSOC);
	    }
	    else {
	        $search = "%{$_GET['search']}%";
                $sql = "SELECT contributorId FROM Contributor WHERE
		    fname LIKE :search OR lname LIKE :search;";
          	$prepared = $pdo->prepare($sql);
	        $result = $prepared->execute(array("search" => $search));
	        $rows = $prepared->fetch(PDO::FETCH_ASSOC);
	    }
	    if (sizeof($rows) > 0) {
		$id = $rows['contributorId'];
		$sqlSearch = "SELECT Song.songId, title, artist, fname, lname FROM Song, Contributor, Contribution WHERE 
			Contribution.contributorId = Contributor.contributorId AND Song.songId = Contribution.songId 
                        AND Song.songId IN (SELECT Song.songId FROM Song, Contribution, Contributor WHERE Song.songId = Contribution.songId AND Contribution.contributorId = Contributor.contributorId AND Contributor.contributorId = $id);";
                $result = $pdo->query($sqlSearch);
                if ($result) {
                    $rows = $result->fetchAll(PDO::FETCH_ASSOC);
		}
		else {
                    $rows = [];
		}
	    }
	}
	else if ($_GET['searchyBy'] == 'song') {
	    $search = "%{$_GET['search']}%";
            $sql = "SELECT Song.songId, title, artist, fname, lname FROM
		    Song, Contributor, Contribution WHERE
		    Contribution.contributorId = Contributor.contributorId AND
                    Song.songId = Contribution.songId AND
                    Song.title LIKE :search;";
            $prepared = $pdo->prepare($sql);
	    $result = $prepared->execute(array("search" => $search));
            $rows = $prepared->fetchAll(PDO::FETCH_ASSOC);
	}
	else if ($_GET['searchyBy'] == 'artist') {
	    $search = "%{$_GET['search']}%";
            $sql = "SELECT Song.songId, title, artist, fname, lname FROM
		    Song, Contributor, Contribution WHERE
                    Contribution.contributorId = Contributor.contributorId AND
                    Song.songId = Contribution.songId AND
		    Song.artist LIKE :search;";
            $prepared = $pdo->prepare($sql);
            $result = $prepared->execute(array("search" => $search));
            $rows = $prepared->fetchAll(PDO::FETCH_ASSOC);
	}
	if (sizeof($rows) == 0) {
            echo "<h1>Sorry, no results found. Please go back and change your search criteria, then try again</h1>";
	}
	else {
	    $double = [];
	    echo "<h2>Results for $_GET[search]</h2>";
	    echo "<form method='POST' action=''>";
	    echo "<table align=center id=resultsTable>";
	    foreach($rows as $rowNum => $row) {
                if ($rowNum == 0) {
                    echo "<tr>";
		    echo "<th style=text-align:center onclick=sortTitle('songTitle')>Title</th>";
		    echo "<th style=text-align:center onclick=sortTitle('artist')>Artist</th>";
		    echo "<th style=text-align:center onclick=sortTitle('contrib')>Contributors</th>";
		    echo "<th style=text-align:center>Select Song</th>";
		    echo "</tr>";
		}
		$isDouble = false;
		if (sizeof($double) > 0) {
                    foreach($double as $d) {
			if ($d == $row['songId']) {
                            $isDouble = true;
			}	
		    }
		}
		if ($isDouble == false) {
		    echo "<tr>";
		    echo "<td name=title>$row[title]</td>";
		    echo "<td>$row[artist]</td>";
		    $song = $row['songId'];
		    $fname = $row['fname'];
		    $matched = false;
		    $contributors = $row['fname'] . " $row[lname]";
		    foreach ($rows as $num => $r) {
                        if ($r['songId'] == $song && $r['fname'] != $fname) {
			//echo "<td>$row[fname] $row[lname], $r[fname] $r[lname]</td>";
			    $contributors = $contributors . ", $r[fname] $r[lname]";
			    $matched = true;
		        }
		    }
		    if ($matched == false) {
                       echo "<td>$row[fname] $row[lname]</td>";
		    }
		    else {
                        echo "<td>$contributors</td>";
		    }
		    echo "<td><input type=radio name=songID value=$row[songId] required /></td>";
		    echo "</tr>";
		}
                    $double[$rowNum] = $row['songId'];
	    }
	    echo "</table>";
	    echo "<br />";
	    echo "Select a Queue: <select name=queue id=queueSelect onchange=showPaid()>";
	    echo "<option value=free>Free Queue</option>";
	    echo "<option value=paid>Paid Queue</option>";
	    echo "</select>";
	    echo "<br />";
	    echo "<div id=test></div>";
	    echo "<br />";
	    echo "<h3>Sign Up</h3>";
	    echo "First Name: <input type=text name=fName required />";
	    echo " Last Name: <input type=text name=lName required />";
	    echo "<br /><br />";
	    echo "<input type=submit value=Submit />";
	    echo "</div>";
	}
}
if (sizeof($_POST) > 0) {
    $songId = $_POST['songID'];
    $queue = $_POST['queue'];
    $fName = $_POST['fName'];
    $lName = $_POST['lName'];
    $sqlUser = "SELECT * FROM User;";
    $resultUser = $pdo->query($sqlUser);
    $rowUser = $resultUser->fetchAll(PDO::FETCH_ASSOC);
    $userId = sizeof($rowUser) + 1;
    $sqlUser = "INSERT INTO User(userId, fname, lname) VALUES (:userId, :fname, :lname);";
    $prepared = $pdo->prepare($sqlUser);
    $result = $prepared->execute(array("userId" => $userId, "fname" => $fName, "lname" => $lName));
    $sqlKaraoke = "SELECT trackId FROM Song, KaraokeTrack, User WHERE
	    Song.songId = $songId AND KaraokeTrack.songId = $songId;";
    $resultKaraoke = $pdo->query($sqlKaraoke);
    $rowKaraoke = $resultKaraoke->fetch(PDO::FETCH_ASSOC);
    if (sizeof($rowKaraoke) > 0) {
	$success = 0;
	$trackID = $rowKaraoke['trackId'];
        if ($queue == 'paid') {
            $paid = floatval($_POST['paid']);
            $sqlPaid = "INSERT INTO PaidQueue(trackId, userId, payAmount, time, isPlayed) 
		       VALUES (:trackId, :userId, :payAmount, CURTIME(), 'false');";
            $preparedPaid = $pdo->prepare($sqlPaid);
	    $success = $preparedPaid->execute(array("trackId" => $trackID, "userId" => $userId, "payAmount" => $paid));
        }
        else {
            $sqlFree = "INSERT INTO FreeQueue(trackId, userId, time, isPlayed)
		    VALUES (:trackId, :userId, CURTIME(), 'false');";
            $preparedFree = $pdo->prepare($sqlFree);
            $success = $preparedFree->execute(array("trackId" => $trackID, "userId" => $userId));
	}
	if ($success == 1) {
            echo "<h3 align=center style=color:#5ad829>Queue Entry Successful! Please wait until your name is called to begin your song.</h3>";
	}
	else {
            echo "<h3 align=center style=color:#b70707>Oops! Something went wrong! Please try again!</h3>";
	}
    }
}

?>
        <script>
            function sortTitle(tableHeader) {
		var table, rows, switching, i, j, a, b, x, y, shouldSwitch, isAscending, num;
		switch(tableHeader) {
                    case 'songTitle':
			    num = 0;
			    break;
		    case 'artist':
			    num = 1;
			    break;
	            case 'contrib':
			    num = 2;
			    break;
	            default:
		}
		table = document.getElementById("resultsTable");
		switching = true;
		isAscending = true;
		rows = table.rows;
		for (j = 1; j < (rows.length -1); j++) {
                    a = rows[j].getElementsByTagName("TD")[num];
	            b = rows[j + 1].getElementsByTagName("TD")[num];
		    if (a.innerHTML.toLowerCase() > b.innerHTML.toLowerCase()) {
		        isAscending = false;
	            }
	        }
		while (switching) {
                    switching = false;
		    rows = table.rows;
		    for (i = 1; i < (rows.length - 1); i++) {
                        shouldSwitch = false;
			x = rows[i].getElementsByTagName("TD")[num];
			y = rows[i + 1].getElementsByTagName("TD")[num];
			if (!isAscending) {
			    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
				shouldSwitch = true;
				break;
			    }
			}
			else {
                            if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()){
                                shouldSwitch = true;
				break;
			    }
			}
		    }
		    if (shouldSwitch) {
                        rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
			switching = true;
		    }
		}
	    }
            function showPaid() {
		var x = document.getElementById("queueSelect").value;
                if (x == "paid") {
		    document.getElementById("test").innerHTML = 
			" <br /> Enter Amount to Pay: $ <input type=number min=0.00 max=25.00 placeholder=0.00 name=paid step=0.01 required/>";
                }
		else {
                    document.getElementById("test").innerHTML = "";
		}
	    }
        </script>
    </body>
</html>
