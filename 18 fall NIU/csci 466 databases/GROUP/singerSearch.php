<html>
    <head>
        <title>Karaoke Song Search</title>
	<style>
            body {
                background-color: #9c9d9e;
            }
            div {
                font-size: 20px;
            }
        </style>
    </head>

    <body text="#283f56">
	<div align="center">
            <br /><br /><br />
	    <h2>Select a criteria to search by, then click search to get results.</h2>
            <br />
            <form method="GET" action="results.php">
                <input type="text" name="search" required />
		<select name="searchyBy" />
                    <option value="artist">Artist</option>
                    <option value="song">Song Title</option>
                    <option value="contributor">Contributor</option>
		</select>
                <input type=submit value="Search" />
	    </form>
        </div>
    </body>
</html>
