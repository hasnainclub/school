 <?php
	// Create page header.
	$pageTitle = "RFQ Status Report";
	include "templates/header.php";

	if (!array_key_exists("query", $_POST))
	{
		echo "<h2>ERROR: No data received!<br/>" .
			 "Please visit the <a href='/~cs56714/csci567/generate-rfq-report.php'>Generate RFQ Report</a><br/>" .
			 "screen to generate a report here!";

		return;
	}

	// Initialize PDO
	include "config/database.php";
	
	// Utility Functions
	function tab($tabs)
	{
		$tabStr = str_repeat("	", $tabs);
		echo $tabStr;
	}
	
	function tabEcho($tabs, $str)
	{
		tab($tabs);
		echo($str . "\n");
	}
	
	function getFormInput($key)
	{
		if (!array_key_exists($key, $_POST))
			exit("$key must be submitted in POST request!");
		
		return $_POST[$key];
	}
	
	// Grab the required fields
	$query = getFormInput("query");
	$sortBy = getFormInput("sortBy");
	$companyId = getFormInput("companyId");
	
	function hasQuery($name)
	{
		$reportType = getFormInput("reportType");
		
		if ($reportType == "detail")
			return true;

		$query = getFormInput("query");
		return array_key_exists($name, $query);
	}
	
	// Split up the sortBy field into an array.
	$sortFields = explode(",", $sortBy);
	
	// Query the data for the report.
	$BIG_FUCKING_QUERY = 
		"SELECT " .
			"RequestForQuote.*, " .
			"Quote.quantity, " .
			"InventoryPart.* " .
		"FROM RequestForQuote " .
			"JOIN Quote on Quote.rfqId = RequestForQuote.rfqId " .
			"JOIN InventoryPart on InventoryPart.inventoryId = Quote.inventoryId " .
			"WHERE companyId = $companyId " .
			"ORDER BY Quote.rfqId";
	
	foreach ($sortFields as $key => $value)
	{
		$orderBy = "";
		
		if ($value == "partName")
			$orderBy = "InventoryPart.partName";
		else if ($value == "partPrice")
			$orderBy = "InventoryPart.price";
		else if ($value == "partNum")
			$orderBy = "InventoryPart.inventoryId";
		else if ($value == "quantity")
			$orderBy = "Quote.quantity";
		else if ($value == "deliverDate")
			$orderBy = "RequestForQuote.deliveryDate";
		else if ($value == "expireDate")
			$orderBy = "RequestForQuote.expireDate";
		
		if (strlen($orderBy) > 0)
			$orderBy = ", " . $orderBy;
		
		$BIG_FUCKING_QUERY .= $orderBy;
	}
	
	$results = $pdo->query($BIG_FUCKING_QUERY . ';');
	
	$currentRfqId = 0;
	$currentTotal = 0;

	$expireDate = 0;
	$deliverDate = 0;
	
	$hasPartNum = hasQuery("partNum");
	$hasPartName = hasQuery("partName");
	$hasPartDesc = hasQuery("partDesc");
	$hasPartPrice = hasQuery("partPrice");
	
	$hasExpireDate = hasQuery("expireDate");
	$hasDeliverDate = hasQuery("deliverDate");
	
	$hasQuantity = hasQuery("quoteQuantity");
	$hasPriceTotal = hasQuery("quoteTotal");

	function closeResult($currentTotal)
	{
		tabEcho(1, "</table>");
		
		if (hasQuery("quoteTotal"))
		{
			tabEcho(1, "<div style='text-align: right'>");
			tabEcho(2, "<small style='position: relative; top: 20px'>Total Price: $$currentTotal</small><br/><br/>");
			tabEcho(1, "</div>");
		}
		else
		{
			tabEcho(2, "<br/>");
		}
		
		tabEcho(0, "</div>");
	}
	
	while ($row = $results->fetch())
	{
		$rfqId = $row["rfqId"];
		
		$expireDate = $row["expireDate"];
		$deliveryDate = $row["deliveryDate"];
		
		$quantity = $row["quantity"];
		$inventoryId = $row["inventoryId"];
		
		$partName = $row["partName"];
		$partDesc = $row["description"];
		$partPrice = $row["price"];
		
		if ($currentRfqId !== $rfqId)
		{
			if ($currentRfqId !== 0)
			{
				closeResult($currentTotal);
				$currentTotal = 0;
			}
			
			tabEcho(0, "<div class='result-box'>");
			tabEcho(1, "<h2 style='margin: 0'>Request For Quote - #$rfqId</h2>");
			
			if ($hasDeliverDate)
			{
				$formatDeliver = strftime("%Y-%m-%d", $deliveryDate);
				tabEcho(1, "<br/><small style='position: relative; top: -50px'>Delivery Date: $formatDeliver</small><br/>");
			}
			else
			{
				tabEcho(1, "<br/>");
			}
			
			if ($hasExpireDate)
			{
				$formatExpire = strftime("%Y-%m-%d", $expireDate);
				tabEcho(1, "<small style='position: relative; top: -50px'>Expire Date: $formatExpire</small><br/>");
			}
			else
			{
				tabEcho(1, "<br/>");
			}
			
			tabEcho(1, "<table class='result-table'>");
			tabEcho(2, "<tr>");

			if ($hasPartNum)
				tabEcho(3, "<th>#</th>");
			
			if ($hasPartName)
				tabEcho(3, "<th>Part Name</th>");
			
			if ($hasPartDesc)
				tabEcho(3, "<th>Description</th>");
			
			if ($hasPartPrice)
				tabEcho(3, "<th>Price</th>");
			
			if ($hasQuantity)
				tabEcho(3, "<th>Quantity</th>");
			
			if ($hasPriceTotal)
				tabEcho(3, "<th>Cost</th>");
			
			tabEcho(2, "</tr>");
			
			$currentRfqId = $rfqId;
		}

		tabEcho(2, "<tr>");
		
		if ($hasPartNum)
			tabEcho(3, "<td>$inventoryId</td>");

		if ($hasPartName)
			tabEcho(3, "<td>$partName</td>");
		
		if ($hasPartDesc)
			tabEcho(3, "<td>$partDesc</td>");
		
		if ($hasPartPrice)
			tabEcho(3, "<td>$$partPrice</td>");
		
		if ($hasQuantity)
			tabEcho(3, "<td>$quantity</td>");
		
		if ($hasPriceTotal)
		{
			$orderPrice = $partPrice * $quantity;
			$currentTotal += $orderPrice;
			tabEcho(3, "<td>$$orderPrice</td>");
		}
		
		tabEcho(2, "</tr>");
	}

	closeResult($currentTotal);
?>