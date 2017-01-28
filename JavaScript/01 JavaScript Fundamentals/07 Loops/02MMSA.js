'use strict'

function solve(args) {
    let min = Math.min(),
        max = Math.max(),
        sum = 0,
        avg = 0;

    for (var i = 0; i < args.length; i += 1) {
        if (args[i] < min) {
            min = +args[i];
        }
        if (args[i] > max) {
            max = +args[i];
        }
        sum += +args[i];
    }
    avg = sum / args.length;

    console.log('min=' + min.toFixed(2))
    console.log('max=' + max.toFixed(2))
    console.log('sum=' + sum.toFixed(2))
    console.log('avg=' + avg.toFixed(2))
}

solve(['2', '-1', '4']);