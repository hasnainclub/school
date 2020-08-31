<?php
	// Create page header.
	$pageTitle = "Create New Account";
	include "templates/header.php";

	// Initialize PDO.
	include "config/database.php";

	// Prepare data insertions.
	$createRep = $pdo->prepare(
		"INSERT INTO CustomerRep(firstName, lastName, email, phone)" .
		"VALUES (:firstName, :lastName, :email, :phone);"
	);

	$createAddress = $pdo->prepare(
		"INSERT INTO Address(addressType, street, city, state, zip)" .
		"VALUES (:addressType, :street, :city, :state, :zip);"
	);

	$createCompany = $pdo->prepare(
		"INSERT INTO Company(compName, shipId, mailId, custRepId)" .
	    "VALUES (:compName, :shipId, :mailId, :custRepId);"
	);
?>

<form id="create-account" method="post">
	<div class="centered">
		<span class="input-title">Company Name</span>
		<input type="text" name="companyName" required>
	</div>

	<div class="centered">
		<div class="block outlined" style="position: relative; top: 80px">
			<h2>Company Representative</h2>

			<table class="form-table">
				<tr>
					<td class="input-title">First Name</td>
					<td class="input">
						<input type="text" name="repFirstName" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">Last Name</td>
					<td class="input">
						<input type="text" name="repLastName" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">Email</td>
					<td class="input">
						<input type="email" name="repEmail" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">Phone Number</td>
					<td class="input">
						<input type="tel" name="repPhone" required>
					</td>
				</tr>
			</table>
		</div>

		<br/>

		<div class="block outlined" style="position: relative; top: 160px;">
			<h2>Mailing Information</h2>

			<table class="form-table">
				<tr>
					<td class="input-title">Street</td>
					<td class="input">
						<input type="text" name="mailStreet" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">City</td>
					<td class="input">
						<input type="text" name="mailCity" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">State</td>
					<td class="input">
						<select name="mailState" required>
                                                    <option value="Alabama">Alabama</option>
                                                    <option value="Alaska">Alaska</option>
                                                    <option value="Arizona">Arizona</option>
                                                    <option value="Arkansas">Arkansas</option>
                                                    <option value="California">California</option>
                                                    <option value="Colorado">Colorado</option>
                                                    <option value="Connecticut">Connecticut</option>
                                                    <option value="Delaware">Delaware</option>
                                                    <option value="Florida">Florida</option>
                                                    <option value="Georgia">Georgia</option>
                                                    <option value="Hawaii">Hawaii</option>
                                                    <option value="Idaho">Idaho</option>
                                                    <option value="Illinois">Illinois</option>
                                                    <option value="Indiana">Indiana</option>
                                                    <option value="Iowa">Iowa</option>
                                                    <option value="Kansas">Kansas</option>
                                                    <option value="Kentucky">Kentucky</option>
                                                    <option value="Louisiana">Louisiana</option>
                                                    <option value="Maine">Maine</option>
                                                    <option value="Maryland">Maryland</option>
                                                    <option value="Massachusetts">Massachusetts</option>
                                                    <option value="Michigan">Michigan</option>
                                                    <option value="Minnesota">Minnesota</option>
                                                    <option value="Mississippi">Mississippi</option>
                                                    <option value="Missouri">Missouri</option>
                                                    <option value="Montana">Montana</option>
                                                    <option value="Nebraska">Nebraska</option>
                                                    <option value="Nevada">Nevada</option>
                                                    <option value="New Hampshire">New Hampshire</option>
                                                    <option value="New Jersey">New Jersey</option>
                                                    <option value="New Mexico">New Mexico</option>
                                                    <option value="New York">New York</option>
                                                    <option value="North Carolina">North Carolina</option>
                                                    <option value="North Dakota">North Dakota</option>
                                                    <option value="Ohio">Ohio</option>
                                                    <option value="Oklahoma">Oklahoma</option>
                                                    <option value="Oregon">Oregon</option>
                                                    <option value="Pennsylvania">Pennsylvania</option>
                                                    <option value="Rhode Island">Rhode Island</option>
                                                    <option value="South Carolina">South Carolina</option>
                                                    <option value="South Dakota">South Dakota</option>
                                                    <option value="Tennessee">Tennessee</option>
                                                    <option value-"Texas">Texas</option>
                                                    <option value="Utah">Utah</option>
                                                    <option value-"Vermont">Vermont</option>
                                                    <option value="Virginia">Virginia</option>
                                                    <option value="Washington">Washington</option>
                                                    <option value="West Virginia">West Virginia</option>
                                                    <option value="Wisconsin">Wisconsin</option>
                                                    <option value="Wyoming">Wyoming</option>
                                        </select>
					</td>
				</tr>
				<tr>
					<td class="input-title">Zip</td>
					<td class="input">
						<input type="text" name="mailZip" required>
					</td>
				</tr>
			</table>
		</div>

		<div class="block outlined" style="position: relative; top: 160px; left: 80px">
			<h2>Shipping Information</h2>

			<table class="form-table">
				<tr>
					<td class="input-title">Street</td>
					<td class="input">
						<input type="text" name="shipStreet" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">City</td>
					<td class="input">
						<input type="text" name="shipCity" required>
					</td>
				</tr>
				<tr>
					<td class="input-title">State</td>
					<td class="input">
                                                <select name="shipState" required>
                                                    <option value="Alabama">Alabama</option>
                                                    <option value="Alaska">Alaska</option>
                                                    <option value="Arizona">Arizona</option>
                                                    <option value="Arkansas">Arkansas</option>
                                                    <option value="California">California</option>
                                                    <option value="Colorado">Colorado</option>
                                                    <option value="Connecticut">Connecticut</option>
                                                    <option value="Delaware">Delaware</option>
                                                    <option value="Florida">Florida</option>
                                                    <option value="Georgia">Georgia</option>
                                                    <option value="Hawaii">Hawaii</option>
                                                    <option value="Idaho">Idaho</option>
                                                    <option value="Illinois">Illinois</option>
                                                    <option value="Indiana">Indiana</option>
                                                    <option value="Iowa">Iowa</option>
                                                    <option value="Kansas">Kansas</option>
                                                    <option value="Kentucky">Kentucky</option>
                                                    <option value="Louisiana">Louisiana</option>
                                                    <option value="Maine">Maine</option>
                                                    <option value="Maryland">Maryland</option>
                                                    <option value="Massachusetts">Massachusetts</option>
                                                    <option value="Michigan">Michigan</option>
                                                    <option value="Minnesota">Minnesota</option>
                                                    <option value="Mississippi">Mississippi</option>
                                                    <option value="Missouri">Missouri</option>
                                                    <option value="Montana">Montana</option>
                                                    <option value="Nebraska">Nebraska</option>
                                                    <option value="Nevada">Nevada</option>
                                                    <option value="New Hampshire">New Hampshire</option>
                                                    <option value="New Jersey">New Jersey</option>
                                                    <option value="New Mexico">New Mexico</option>
                                                    <option value="New York">New York</option>
                                                    <option value="North Carolina">North Carolina</option>
                                                    <option value="North Dakota">North Dakota</option>
                                                    <option value="Ohio">Ohio</option>
                                                    <option value="Oklahoma">Oklahoma</option>
                                                    <option value="Oregon">Oregon</option>
                                                    <option value="Pennsylvania">Pennsylvania</option>
                                                    <option value="Rhode Island">Rhode Island</option>
                                                    <option value="South Carolina">South Carolina</option>
                                                    <option value="South Dakota">South Dakota</option>
                                                    <option value="Tennessee">Tennessee</option>
                                                    <option value-"Texas">Texas</option>
                                                    <option value="Utah">Utah</option>
                                                    <option value-"Vermont">Vermont</option>
                                                    <option value="Virginia">Virginia</option>
                                                    <option value="Washington">Washington</option>
                                                    <option value="West Virginia">West Virginia</option>
                                                    <option value="Wisconsin">Wisconsin</option>
                                                    <option value="Wyoming">Wyoming</option>
                                        </select>


					</td>
				</tr>
				<tr>
					<td class="input-title">Zip</td>
					<td class="input">
						<input type="text" name="shipZip" required>
					</td>
				</tr>
			</table>
		</div>
	</div>

	<?php
		$buttonStyle = "position: relative; top: 180";
		include("templates/buttons.php")
	?>
</form>

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
	
	$companyName  = getFormInput("companyName");
	
	$repFirstName = getFormInput("repFirstName");
	$repLastName  = getFormInput("repLastName");
	$repEmail     = getFormInput("repEmail");
	$repPhone     = getFormInput("repPhone");
	
	$mailStreet   = getForminput("mailStreet");
	$mailState    = getFormInput("mailState");
	$mailCity     = getFormInput("mailCity");
	$mailZip      = getFormInput("mailZip");
	
	$shipStreet   = getForminput("shipStreet");
	$shipState    = getFormInput("shipState");
	$shipCity     = getFormInput("shipCity");
	$shipZip      = getFormInput("shipZip");
	
	// Create the representative
	$createdRep = $createRep->execute(
	[
		"firstName" => $repFirstName,
		"lastName"  => $repLastName,
		"email"     => $repEmail,
		"phone"     => $repPhone
	]);
	
	if ($createdRep)
	{
		// Store the representative ID
		$repId = $pdo->lastInsertId("CustomerRep");
		
		// Create the mailing address
		$createdMail = $createAddress->execute(
		[
			"addressType" => "mailing",
			"street"      => $mailStreet,
			"city"        => $mailCity,
			"state"       => $mailState,
			"zip"         => $mailZip
		]);
		
		if ($createdMail)
		{
			// Store the mailing address ID
			$mailId = $pdo->lastInsertId("Address");
			
			// Create the shipping address
			$createdShip = $createAddress->execute(
			[
				"addressType" => "shipping",
				"street"      => $shipStreet,
				"city"        => $shipCity,
				"state"       => $shipState,
				"zip"         => $shipZip
			]);
			
			if ($createdShip)
			{
				// Store the shipping address ID
				$shipId = $pdo->lastInsertId("Address");
				
				// Create the company account
				$createdCompany = $createCompany->execute(
				[
					"compName"  => $companyName,
					"shipId"    => $shipId,
					"mailId"    => $mailId,
					"custRepId" => $repId,
				]);
				
				if ($createdCompany)
				{
					$companyId = $pdo->lastInsertId("Company");
					echo "Created Company! (ID: $companyId)";
				}
				else
				{
					exit("Could not create company!");
				}
			}
			else
			{
				exit("Could not create shipping address!");
			}
		}
		else
		{
			exit("Could not create mailing address!");
		}
	}
	else
	{
		exit("Could not create company representative!");
	}
?>
