/* Trapezoids
Calculate trapezoid's area by given sides 
a and b and height h. The three values should be read from the console in the 
order shown below. All three value will be floating-point numbers.
*/

'use strict'

function solve(args) {
    const b = +args[1],
        h = +args[2],
        a = +args[0];
    const area = ((a + b) * h) / 2;
    console.log(area.toFixed(7));
}

solve(['5', '7', '12']);
solve(['2', '1', '33']);
solve(['8.5', '4.3', '2.7']);
solve(['100', '200', '300']);
solve(['0.222', '0.333', '0.555']);