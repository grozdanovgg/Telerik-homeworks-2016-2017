function solve(args) {
    var size = +args[0];
    var arr = [size + 1];
    var count = 2;
    while (count != size + 1) {
        if (arr[count]) {
            count++;
            continue;
        } else if (count * count > size) {
            break;
        } else {
            for (i = count * count; i <= size; i += count) {
                arr[i] = true;
            }
            count += 1;
        }
    }

    console.log(count);
}

solve([13])