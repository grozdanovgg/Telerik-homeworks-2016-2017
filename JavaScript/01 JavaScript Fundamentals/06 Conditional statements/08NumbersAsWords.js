'use strict'

function solve(args) {

    const number = +args[0],
        onesText = ["", 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'],
        tensText = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
    let ones = null,
        tens = null,
        hundreds = null,
        result = null,
        firstChar = null,
        restOfString = null;
    // var a = n.charAt(0).toUpperCase() + n.slice(1)
    if (number === 0) {
        result = "zero"
    } else if (number < 20) {
        ones = number;
        result = `${onesText[ones]}`;
    } else if (number >= 20 && number < 100) {
        ones = +(number.toString()[1]);
        tens = +(number.toString()[0]);
        if (ones == 0) {
            result = `${tensText[tens]}`
        } else {
            result = `${tensText[tens]} ${onesText[ones]}`;
        }
    } else {
        ones = number.toString()[2];
        tens = number.toString()[1];
        hundreds = number.toString()[0];
        if (tens == 0) {
            if (ones == 0) {
                result = `${onesText[hundreds]} hundred`;
            } else {
                result = `${onesText[hundreds]} hundred and ${onesText[ones]}`;
            }
        } else if (tens < 2) {
            result = `${onesText[hundreds]} hundred and ${onesText[tens+ones]}`
        } else {
            result = `${onesText[hundreds]} hundred and ${tensText[tens]} ${onesText[ones]}`
        }
    }
    firstChar = result.slice(0, 1).toUpperCase();
    restOfString = result.slice(1)
    console.log(firstChar + restOfString);
}

solve(['711']);
solve(['999']);
solve(['617']);