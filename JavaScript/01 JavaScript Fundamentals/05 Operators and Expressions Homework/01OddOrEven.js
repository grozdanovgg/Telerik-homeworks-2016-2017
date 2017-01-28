/*
1. check if given integer is odd or even
2. prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.

// НЕ ПИШЕТЕ НИЩО ТУК

function solve(args) {
	var a = +args[0], // cast string to Number
		b = +args[1]; // cast string to Number

	console.log(a + b);
	console.log(a * b);
}

// НЕ ПРАЩАЙТЕ ДОЛНИТЕ РЕДОВЕ В BGCODER

solve(['3', '5']);
solve(['11', '4']);
solve(['17', '17']);
*/
'use strict'

function solve(args) {
    const testNum = +args[0]; // cast string to Number

    if (testNum % 2 == 0) {
        console.log("even" + " " + testNum)
    } else {
        console.log("odd" + " " + testNum)
    }
}