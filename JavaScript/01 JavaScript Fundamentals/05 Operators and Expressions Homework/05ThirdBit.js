'use strict'

function solve(args) {
    const n = +args[0]; // cast string to Number

    let bitValue = ( n >> 3 ) & 1 ;
    console.log(bitValue);
}

solve(['1751']);
