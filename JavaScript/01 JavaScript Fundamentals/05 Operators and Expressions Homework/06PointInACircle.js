/*
1. check if given point (x, y) is inside a circle K({0, 0}, 2) -
the center has coordinates (0, 0) and the circle has radius 2. 
 
2. The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
*/

'use strict'

function solve(args) {
    const x = Math.pow(Math.abs(+args[0]), 2),
        y = Math.pow(Math.abs(+args[1]), 2),
        z = Math.sqrt(x + y),
        r = 2;

    if (z <= r) {
        console.log("yes " + z.toFixed(2))
    } else {
        console.log("no " + z.toFixed(2))
    }
}

solve(['-2', '0']);
solve(['-1', '2']);
solve(['100', '-30']);
solve(['0', '0']);
solve(['0.2', '-0.8']);