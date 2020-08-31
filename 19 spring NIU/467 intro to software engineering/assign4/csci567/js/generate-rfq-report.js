//////////////////////////////////////////////////////////////////////////////
// Sortable Setup
//////////////////////////////////////////////////////////////////////////////

var items = $("#sortable");;
var sortBy = $("#sortBy");

function updateSort(event, ui)
{
	var order = items
		.sortable("toArray")
		.toString();
	
	sortBy.val(order);
}

items.sortable(
{
	placeholder: "ui-state-highlight",
	cursor: 'crosshair',
	update: updateSort
});

updateSort();

//////////////////////////////////////////////////////////////////////////////
// Disable content options when detailed mode is enabled.
//////////////////////////////////////////////////////////////////////////////

$("input[type=radio]").click(function ()
{
	var name = $(this).attr("value");
	var checkBoxes = $(":checkBox");
	
	if (name === "detail")
	{
		checkBoxes.attr("checked", "true");
		checkBoxes.attr("disabled", "true");
	}
	else
	{
		checkBoxes.removeAttr("disabled");
	}
});

//////////////////////////////////////////////////////////////////////////////
// Initialize default values for the start/end dates
//////////////////////////////////////////////////////////////////////////////

var date = new Date();

var year = date.getFullYear();
var day = ('0' + date.getDate()).slice(-2);
var month = ('0' + (date.getMonth() + 1)).slice(-2);

var startDate = year + '-' + month + "-01";
var endDate = year + '-' + month + '-' + day;

$("#startDate").val(startDate);
$("#endDate").val(endDate);

//////////////////////////////////////////////////////////////////////////////