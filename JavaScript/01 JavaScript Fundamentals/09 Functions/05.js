//Write a method that checks if the element at given position in given array of integers is larger 
//than its two neighbours (when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

function solve(args) {
    let arrSize = args[0],
        arr = args[1].split(' ');

    largerThanNeighbCount(arr)

    function largerThanNeighbCount(arr) {
        let count = 0;

        for (let i = 1; i < arrSize - 1; i += 1) {
            if (+arr[i] > +arr[i - 1] && +arr[i] > +arr[i + 1]) {
                count += 1;
            }
        }
        return console.log(count);
    }

}

solve(["6", "-26 -25 -28 31 2 27"])