/*
Prime check

check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

Note: You should check if the number is positive.
*/

'use strict'

function solve(args) {
    var number = +args[0];
    var isPrime = true;

    if (number < 2) {
        isPrime = false;
    } else if (number == 2) {
        isPrime = true;
    } else {
        for (var i = 2; i <= Math.sqrt(number); i++) {

            if (number % i == 0) {
                isPrime = false;
                break;
            }
        }
    }
    console.log(isPrime)
}

solve(['16']);
solve(['52']);
solve(['23']);
solve(['-13']);
solve(['2']);

console.log(5 % 2)