<?php
	// Create page header.
	$pageTitle = "Create New Part";
	include "templates/header.php";
	
	// Initialize PDO.
	include "config/database.php";
	
	// Declare PDO query for creating parts.
	$addPart = $pdo->prepare("INSERT INTO InventoryPart(partName, description, price)" .
	                         "VALUES (:partName, :description, :price);");
?>

<div class="centered">
	<form id="submit-part" action="create-part.php" method="post">
		<table class="form-table centered">
			<tr>
				<td class="input-title">Name</td>
				<td class="input">
					<input type="text" name="partName" required>
				</td>
			</tr>
			<tr>
				<td class="input-title">Price</td>
				<td class="input">
					<input type="number" name="price" min="0.01" step="0.01" value="10.00" required>
				</td>
			</tr>
			<tr>
				<td class="input-title text-upper">Description</td>
				<td class="input">
					<textarea form="submit-part" name="description" required></textarea>
				</td>
			</tr>
		</table>
		
		<?php include("templates/buttons.php") ?>
	</form>
</div>

<br/><br/>

<?php
	// If the form has been submitted, process the result.
	if (empty($_POST))
		return;
	
	function getFormInput($key)
	{
		if (!array_key_exists($key, $_POST))
			exit("$key must be submitted in POST request!");
		
		return $_POST[$key];
	}
	
	$description = getFormInput("description");
	$partName = getFormInput("partName");
	$price = getFormInput("price");
	
	// Prepare our DDL statement.
	
	$success = $addPart->execute(
	[
		"description" => $description,
		"partName"    => $partName,
		"price"       => $price,
	]);
	
	if ($success == false)
		exit("Failed to create a part in the database!");
	
	echo "Part created!";
?>