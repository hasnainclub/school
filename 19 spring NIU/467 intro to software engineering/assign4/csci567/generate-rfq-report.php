<?php
	// Create page header.
	$pageTitle = "Generate RFQ Status Report";
	include "templates/header.php";
	
	// Initialize PDO.
	include "config/database.php";
?>

<div class="centered" style="max-width: 1000px">
	<form id="generate-rfq-report" action="rfq-report.php" method="post">	
		<?php include "templates/select-company.php" ?>
		
		<div class="block bordered" style="position: relative; top: 16">
			<h2>Report Type</h2>
			<table>
				<tr><td>
					<input id="reportType" name="reportType" type="radio" value="summary" required checked>Summary</input>
				</td></tr>
				<tr><td>
					<input id="reportType" name="reportType" type="radio" value="detail" required>Detailed</input>
				</td></tr>
			</table>
		</div>
		
		<div class="block bordered" style="position: relative; top: 4px; left: 96">
			<h2>Date</h2>
			<table class="form-table centered">
				<tr><td>
					<span class="input-title">Start Date</span>
					<input style="padding: 0px" id="startDate" type="date" name="query[startDate]" required></input>
				</td></tr>
				<tr><td>
					<span class="input-title" style="padding-left: 20px">End Date</span>
					<input style="padding: 0px" id="endDate" type="date" name="query[endDate]" required></input>
				</td></tr>
			</table>
		</div>

		<br/>
		
		<div class="block bordered" style="position: relative; left: 170; top: 40">
			<h2>Content</h2>
			
			<div class="block">
				<table class="form-table centered">
					<tr>
						<td>
							<input id="partName" type="checkbox" name="query[partName]" checked>Part Name</input>
						</td>
						<td>
							<input id="partPrice" type="checkbox" name="query[partPrice]" checked>Part Price</input>
						</td>
					</tr>
					<tr>
						<td>
							<input id="partDesc" type="checkbox" name="query[partDesc]" checked>Part Description</input>
						</td>
						<td>
							<input id="partNum" type="checkbox" name="query[partNum]" checked>Part Number</input>
						</td>
					</tr>
					<tr>
						<td>
							<input type="checkbox" name="query[deliverDate]" checked>Delivery Date</input>
						</td>
						<td>
							<input type="checkbox" name="query[expireDate]" checked>Expiration Date</input>
						</td>
					</tr>
					<tr>
						<td>
							<input id="quantity" type="checkbox" name="query[quoteQuantity]" checked>Quantity</input>
						</td>
						<td>
							<input type="checkbox" name="query[quoteTotal]" checked>Total Price</input>
						</td>
					</tr>
				</table>
			</div>
		</div>
		
		<br/>
		
		<div class="block bordered" style="position: relative; left: -165; top: -181;">
			<h2>Sort By</h2>
			
			<ul class="rfq-sort-by"  id="sortable">
				<li id="partName"    class="ui-state-default">↕ Part Name</li>
				<li id="partPrice"   class="ui-state-default">↕ Part Price</li>
				<li id="partNum"     class="ui-state-default">↕ Part Number</li>
				<li id="quantity"    class="ui-state-default">↕ Part Quantity</li>
				<li id="deliverDate" class="ui-state-default">↕ Delivery Date</li>
				<li id="expireDate"  class="ui-state-default">↕ Expiration Date</li>
			</ul>
			
			<input name="sortBy" type="hidden" id="sortBy" required></input>
		</div>
		
		<?php
			$buttonStyle = "position: relative; top: -150";
			include "templates/buttons.php";
		?>
		
		<script src="js/generate-rfq-report.js"/></script>
	</form>
</div>