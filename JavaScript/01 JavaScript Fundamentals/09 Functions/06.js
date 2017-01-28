//Write a method that returns the index of the first 
//element in array that is larger than its neighbours, or -1, if there is no such element.

function solve(args) {
    let arrSize = args[0],
        arr = args[1].split(' ');

    IndexOfFirstLargerThanNeighb(arr)

    function IndexOfFirstLargerThanNeighb(arr) {
        let index = 1;

        for (let i = 1; i < arrSize - 1; i += 1) {
            if (+arr[i] > +arr[i - 1] && +arr[i] > +arr[i + 1]) {
                return console.log(i);
            }
        }
        return console.log('-1');
    }
}

solve(["6", "-26 -25 -28 31 2 27"])