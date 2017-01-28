function solve(args) {

    let n = args[0],

        newList = [],
        min = args[1],
        index = 0,
        tempArr = [];

    args = args.splice(1, n - 1);

    //Magic
    for (var i = 1; i < n; i += 1) {
        min = Math.min.apply(Math, args);
        index = args.indexOf(String(min));
        args.splice(index, 1);
        newList.push(min);
    }

    //Printing the result
    for (var i = 0; i < n; i += 1) {
        console.log(newList[i])
    }
}
//    let newList = list.join(' ');
//  console.log(newList);
solve(['6', '3', '4', '1', '5', '2', '6']);
solve(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);