<?php
	// Create page header.
	$pageTitle = "Create New Request For Quote";
	include "templates/header.php";
	
	// Initialize PDO.
	include "config/database.php";
	
	// Declare static PDO queries to be used.
	$invParts = $pdo->query("SELECT partName, inventoryId FROM InventoryPart");
	
	// Prepare PDO queries for creating the RFQ and Quote objects.
	$createRFQ = $pdo->prepare(
		"INSERT INTO RequestForQuote(companyId, expireDate, deliveryDate)" .
		"VALUES (:companyId, :expireDate, :deliveryDate);"
	);
	
	$createQuote = $pdo->prepare(
		"INSERT INTO Quote(rfqId, inventoryId, quantity)" .
		"VALUES (:rfqId, :inventoryId, :quantity);"
	);
	
	// Attributes to use for the quantity input fields.
	$quantityConfig = "type='number' min=0 max=99999";
	
	// Utility functions for writing HTML with tabs.
	function tab($tabs)
	{
		$tabStr = str_repeat("	", $tabs);
		echo $tabStr;
	}
	
	function tabEcho($tabs, $str)
	{
		tab($tabs);
		echo($str);
	}
?>

<form id="submit-rfq" method="post">
	<?php include "templates/select-company.php" ?>
	
	<h2>Quote Data</h2>
	
	<table class="form-table centered">
		<tr class="input-header">
			<th>Name</th>
			<th>Order Quantity</th>
		</tr>
		
		<?php
			$first = true;
			
			while ($part = $invParts->fetch())
			{
				// Choose tabs to use for the tr tag.
				$openTabs = 2;
				
				if ($first)
				{
					$first = false;
					$openTabs = 0;
				}
				
				// Open table row.
				tabEcho($openTabs, "<tr>\n");
				
				// Add the part name
				$partId = $part["inventoryId"];
				$partName = $part["partName"];
				
				tabEcho(3, "<td>$partName</td>\n");
				
				// Add the quantity input field
				tabEcho(3, "<td>\n");
				tabEcho(4, "<input name='quantities[$partId]' $quantityConfig>\n");
				tabEcho(3, "</td>\n");
				
				// Close table row.
				tabEcho(2, "</tr>\n");
			}
		?>
	</table>
	
	<?php include("templates/buttons.php") ?>
</form>

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
	
	$companyId = getFormInput("companyId");
	$quantities = getFormInput("quantities");
	
	// Make sure at least one of the quantities are set
	$hasQuantitySet = false;
	
	foreach ($quantities as $inventoryId => $quantity)
	{
		if (isset($quantity) && is_numeric($quantity))
		{
			$hasQuantitySet = true;
			break;	
		}
	}
	
	if (!$hasQuantitySet)
		return;
	
	// Compute the input dates for the RFQ.
	$now = time();
	$day = 86400;
	
	$deliveryDate = $now + (7 * $day); // 7 Days
	$expireDate = $now + (30 * $day); // 30 Days
	
	// Create the RFQ.
	$rfqCreated = $createRFQ->execute(
	[
		"companyId"    => $companyId,
		"expireDate"   => $expireDate,
		"deliveryDate" => $deliveryDate
	]);
	
	if ($rfqCreated)
	{
		// Fetch the last RFQ ID.
		$getId = $pdo->query("SELECT MAX(rfqId) as result FROM RequestForQuote;");
		$rfqId = $getId->fetch()["result"];
		
		// Placeholder debug messages?
		echo "<h2>Results</h2>\n";
		echo "\n<div>Created RFQ with ID: $rfqId</div>\n";
		echo "<ul>\n";
		
		// Generate the Quotes for the RFQ.
		foreach ($quantities as $inventoryId => $quantity)
		{
			if (isset($quantity) && is_numeric($quantity))
			{
				$quoteCreated = $createQuote->execute(
				[
					"rfqId"       => $rfqId,
					"inventoryId" => $inventoryId,
					"quantity"    => $quantity,
				]);
				
				if (!$quoteCreated)
				{
					echo("Failed to generate quote! (Part ID: $inventoryId)");
				}
			}
		}
	}
	else
	{
		exit("Failed to create RFQ!");
	}
?>

</div>