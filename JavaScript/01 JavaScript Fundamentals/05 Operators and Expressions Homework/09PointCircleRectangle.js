/* Point, Circle, Rectangle

Check for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

'use strict'

function solve(args) {

    var x = args[0],
        y = args[1];

    if (Math.pow((x - 1), 2) + Math.pow((y - 1), 2) <= Math.pow(1.5, 2)) {
        if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1)) {
            console.log('inside circle inside rectangle');
        } else {
            console.log('inside circle outside rectangle');
        }

    } else {
        if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1)) {
            console.log('outside circle inside rectangle');
        } else {
            console.log('outside circle outside rectangle');
        }
    }
}

solve(['2.5', '2']);
solve(['0', '1']);
solve(['2.5', '1']);