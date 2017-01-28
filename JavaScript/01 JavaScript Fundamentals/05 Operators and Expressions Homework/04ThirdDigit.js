'use strict'

function solve(args) {
    const n = +args[0]; // cast string to Number

    if ((n / 100 | 0) % 10 == 7) {
        console.log("true");
    } else {
        console.log("false " + (n / 100 | 0) % 10);
    }
}

solve(['1751']);
solve(['36']);