'use strict'

function solve(args) {
    const n = +args[0],
        list = [];


    for (var row = 0; row < n; row += 1) {
        for (var col = row; col < n + row; col += 1) {
            list[col - row] = col + 1;
        }
        console.log(list.join(' '))
    }



}

solve(['2']);
solve(['3']);
solve(['4']);