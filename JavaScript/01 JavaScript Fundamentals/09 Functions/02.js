function solve(args) {

    let array = args[0].split(' '),
        a = +array[0],
        b = +array[1],
        c = +array[2];

    function getMax(a, b) {
        if (a > b) {
            return a;
        } else {
            return b;
        }
    }

    return (getMax(getMax(a, b), c));
}

solve(["2 4 5"])