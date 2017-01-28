function solve(args) {
    const n = args[0],
        list = [];

    for (var index = 0; index < n; index += 1) {

        list[index] = index + 1;
    }
    let newList = list.join(' ');
    console.log(newList);
}

solve(['5']);
solve(['1']);