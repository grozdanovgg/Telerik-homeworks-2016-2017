//Write a method that returns the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

function solve(args) {
    let arrSize = args[0],
        arr = args[1].split(' '),
        result = "",
        sortedArray = [];

    // sortedArray = arr.sort();
    // result = sortedArray.join(" ");
    // console.log(result);


    function MaximalInSubArray(arr, startIndex) {
        let max = -Number.MAX_VALUE;
        for (let i = startIndex; i < arr.length; i += 1) {
            if (+arr[i] > max) {
                max = +arr[i];
            }
        }
        return max;
    }
}



solve(["10", "36 10 1 34 28 38 31 27 30 20"])