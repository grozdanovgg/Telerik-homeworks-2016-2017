'use strict'

function solve(args) {
    let max = +args[0];

    for (var i = 1; i < 5; i += 1) {

        if (+args[i] > max) {
            max = +args[i]
        }
    }
    console.log(max)
}

solve(['-2', '-22', '1', '0', '0']);
solve(['-3', '-0.5', '-1.1', '-2', '-0.1']);
solve(['5', '2', '2', '4', '1']);
solve(['-2', '4', '3', '2', '0']);
solve(['0', '-2.5', '0', '5', '5']);