function solve(args) {
    let n = args[0],
        count = 1,
        maxCount = 0,
        number = 0;

    args = args.splice(1, n - 1);
    args.sort();

    for (var i = 1; i < args.length; i++) {

        if (args[i] === args[i - 1]) {
            count += 1;
        } else {
            count = 1;
        }

        if (count > maxCount) {
            maxCount = count;
            number = args[i];
        }
    }


    if (args.length === 1) {
        maxCount = 1;
        number = arr[0];
    }
    //REPEATING_NUMBER (REPEATED_TIMES times)
    console.log(`${number} (${maxCount}) times`)
}

solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);