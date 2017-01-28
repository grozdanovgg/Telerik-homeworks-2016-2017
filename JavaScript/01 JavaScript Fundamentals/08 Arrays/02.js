function solve(args) {
    const a = args[0],
        b = args[1];


    if (a < b) {
        console.log('<')
    } else if (a > b) {
        console.log('>')
    } else {
        console.log('=')
    }


    //    let newList = list.join(' ');
    //  console.log(newList);
}

solve(['hello', 'halo']);
solve(['food', 'food']);