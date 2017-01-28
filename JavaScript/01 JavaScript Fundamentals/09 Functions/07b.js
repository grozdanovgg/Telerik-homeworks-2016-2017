function solve(args) {
    var i,
        j,
        maxElement,
        maxPosition, // the position of the max element
        len = +args[0],
        numbers = args[1].split(' ');


    // The Sorted array in ascending order
    ascendingSorter(numbers, len);
    console.log(numbers.join(' '));

    function maxElementFromGivenIndex(numbersArray, length, startPosition) {
        maxElement = +numbersArray[startPosition];
        maxPosition = startPosition;

        for (j = startPosition + 1; j < length; j += 1) {
            if (maxElement < +numbersArray[j]) {
                maxElement = +numbersArray[j];
                maxPosition = j;
            }
        }

        return maxElement;
    }

    function ascendingSorter(numbersArray, length) {
        max = 0;
        maxPosition = 0;

        for (i = 0; i < length; i += 1) {
            max = maxElementFromGivenIndex(numbersArray, length - i, 0);
            numbersArray[maxPosition] = numbersArray[length - 1 - i];
            numbersArray[length - 1 - i] = max;
        }

    }
}

solve(["10", "36 10 1 34 28 38 31 27 30 20"])