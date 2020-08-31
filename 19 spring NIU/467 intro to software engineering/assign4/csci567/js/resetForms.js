// This defines a basic function to reset all form elements on the page.
// It is used by the cancel button defined in 'templates/buttons.php'

function resetAllForms()
{
	var forms = document.getElementsByTagName("form");
	
	for (var i = 0; i < forms.length; i++)
	{
		var form = forms[i];
		form.reset();
	}
}