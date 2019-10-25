let display = document.getElementById("display");

let operationSymbol = null;
let currentValue = "";
let second;

document.querySelectorAll('.i').forEach(function(item) {
    item.addEventListener('click', function() {
		if (second){
			second = false;
			display.value = "";
		}
        display.value == "0" ? display.value = item.innerHTML : display.value += item.innerHTML;
	});
});

function reset() { 
    display.value = "";
	operationSymbol = null;
	currentValue = "";
}

function addNul(){ 
	(display.value === "") ? display.value === "" : display.value += "0";
} 

function operation(op){
	operationSymbol = op;
	currentValue = display.value;
	second = true;
}

function equal(op){
	if(operationSymbol == null || currentValue == ""){
		return;
	}
	let x, y, result;
	x = Number(currentValue);
	y = Number(display.value);
	
	switch (operationSymbol) {
		case "+":
			result = x + y;
			break;
		case "-":
			result = x - y;
			break;
		case "/":
			result = x / y;
			break;
		case "*":
			result = x * y;
			break;
		case "=":
			display.value = display.value;
	}
	operationSymbol = null;
	second = true;
	display.value = result;
}