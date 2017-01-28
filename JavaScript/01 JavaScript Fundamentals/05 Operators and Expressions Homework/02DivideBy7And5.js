'use strict'

function solve(args) {
    const n = +args[0]; // cast string to Number

    if (n % 7 == 0 && n % 5 == 0 ) {
        console.log("true " + n)
    } else {
        console.log("false " + n)
    }
}

solve(['35']);
solve(['36']);