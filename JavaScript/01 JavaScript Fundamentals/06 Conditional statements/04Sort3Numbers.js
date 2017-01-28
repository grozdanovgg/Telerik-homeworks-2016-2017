// a b c
// a c b 
// b a c
// b c a
// c a b 
// c b a
'use strict'

function solve(args) {
    let a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a >= b && b >= c) {
        console.log(`${a} ${b} ${c}`);
    } else if (a >= c && c >= b) {
        console.log(`${a} ${c} ${b}`);
    } else if (b >= a && a >= c) {
        console.log(`${b} ${a} ${c}`);
    } else if (b >= c && c >= a) {
        console.log(`${b} ${c} ${a}`);
    } else if (c >= a && a >= b) {
        console.log(`${c} ${a} ${b}`);
    } else if (c >= b && b >= a) {
        console.log(`${c} ${b} ${a}`);
    }
}


solve(['3', '-5', '-5']);
solve(['-2', '-2', '1']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);
solve(['-1.1', '-0.5', '-0.1']);