<script src="js/resetForms.js"></script>

<script src="js/submitForms.js"></script>

<div class="centered" style="<?php if (isset($buttonStyle)) echo $buttonStyle; ?>">
	<button type="button" class="cancel" onClick="resetAllForms()">Cancel</button>
	<input type="submit" onClick="confirmation()" value="Submit">
</div>
