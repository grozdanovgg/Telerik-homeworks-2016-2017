function solve(args) {
    let arrSize = args[0],
        arr = args[1].split(' '),
        x = args[2];

    appearacneCount(x, arr)

    function appearacneCount(x, arr) {
        let count = 0,
            i = "";

        for (i in arr) {
            if (arr[i] === x) {
                count += 1;
            }
        }
        return console.log(count);
    }

}

solve(["42", "28 6 21 6 -7856 73 73 -56", "73"])