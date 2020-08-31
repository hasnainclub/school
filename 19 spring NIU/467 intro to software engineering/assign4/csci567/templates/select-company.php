<table class="form-table centered">
	<tr>
		<td class="input-title">Select Company</td>
		<td class="input">
			<select name="companyId">
			<?php
				include "config/database.php";
				$companies = $pdo->query("SELECT compName, companyId FROM Company");

				while ($company = $companies->fetch())
				{
					$compId = $company["companyId"];
					$compName = $company["compName"];

					echo("<option value=$compId>$compName</option>\n");
				}
			?>
			</select>
		</td>
	</tr>
</table>
