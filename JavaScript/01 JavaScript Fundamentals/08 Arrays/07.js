function solve(args) {
    let n = args[0],
        x = args[Number(n) + 1],
        arr = args.slice(1, n + 1),
        min = 0,
        max = n - 1,
        middle = (n - 1) / 2 | 0,
        number = 0;




    while (arr[middle] != x && min <= max) {
        middle = (min + max) / 2 | 0;
        if (arr[middle] < x) {
            min = middle + 1;
        } else {
            max = middle - 1;
        }
    }


    if (arr[middle] != x) {
        console.log('-1');
    } else {
        console.log(middle);
    }


    //console.log(`${number} (${maxCount}) times`)
}

solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);