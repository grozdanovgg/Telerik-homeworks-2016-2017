function solve(args) {
    const n = args[0]
    let count = 1,
        max = 1;

    for (var i = 1; i < n; i += 1) {

        if (args[i] < args[i + 1]) {
            count += 1;
        } else {
            count = 1;
        }
        if (count > max) {
            max = count;
        }
    }
    console.log(max);
}
//    let newList = list.join(' ');
//  console.log(newList);

solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);