// Generate 10 random 3-digit numbers and store them in an array
let numbers = Array.from({ length: 10 }, () => Math.floor(Math.random() * 900) + 100);
console.log("Generated Numbers:", numbers);

// Function to find 2nd largest and 2nd smallest without sorting
function findSecondLargestSmallest(arr) {
    let firstMax = -Infinity, secondMax = -Infinity;
    let firstMin = Infinity, secondMin = Infinity;

    for (let num of arr) {
        if (num > firstMax) {
            secondMax = firstMax;
            firstMax = num;
        } else if (num > secondMax && num !== firstMax) {
            secondMax = num;
        }

        if (num < firstMin) {
            secondMin = firstMin;
            firstMin = num;
        } else if (num < secondMin && num !== firstMin) {
            secondMin = num;
        }
    }

    return { secondLargest: secondMax, secondSmallest: secondMin };
}

let result = findSecondLargestSmallest(numbers);
console.log("2nd Largest:", result.secondLargest);
console.log("2nd Smallest:", result.secondSmallest);
