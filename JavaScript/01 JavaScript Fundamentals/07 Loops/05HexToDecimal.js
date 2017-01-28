function solve(args) {
    let hex = args[0],
        counter = 0,
        sum = 0,
        hexTest = hex[0];
    for (i = hex.length; i > 0; i -= 1) {
        switch (hex[i - 1]) {
            case "A":
                sum = sum + (10 * Math.pow(16, counter));
                break;
            case "B":
                sum = sum + (11 * Math.pow(16, counter));
                break;
            case "C":
                sum = sum + (12 * Math.pow(16, counter));
                break;
            case "D":
                sum = sum + (13 * Math.pow(16, counter));
                break;
            case "E":
                sum = sum + (14 * Math.pow(16, counter));
                break;
            case "F":
                sum = sum + (15 * Math.pow(16, counter));
                break;
            default:
                sum = sum + (+hex[i - 1] * Math.pow(16, counter));
                break;
        }
        counter += 1;
    }
    console.log(sum);
}


solve(['1AE3']);
solve(['FE']);
solve(['4ED528CBB4']);