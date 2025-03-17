// Generate 5 random 3-digit numbers (between 100 and 999)
let numbers = [];
for (let i = 0; i < 5; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100);
}

// Initialize min and max with the first number
let min = numbers[0];
let max = numbers[0];

// Loop to find min and max using if-else
for (let i = 1; i < numbers.length; i++) {
    if (numbers[i] < min) {
        min = numbers[i];
    } else if (numbers[i] > max) {
        max = numbers[i];
    }
}

// Print results
console.log("Generated Numbers:", numbers);
console.log("Minimum Value:", min);
console.log("Maximum Value:", max);
