'use strict'

function solve(args) {
    let a = +args[0],
        b = +args[1],
        c = null;

    if (a > b) {
        c = b;
        b = a
        a = c;
    }
    console.log(`${a} ${b}`)
}


solve(['5', '2']);
solve(['3', '4']);