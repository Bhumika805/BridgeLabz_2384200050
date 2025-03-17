// Generate 5 random 2-digit numbers (between 10 and 99)
let numbers = [];
for (let i = 0; i < 5; i++) {
    numbers.push(Math.floor(Math.random() * 90) + 10);
}

// Calculate sum
let sum = numbers.reduce((acc, num) => acc + num, 0);

// Calculate average
let average = sum / numbers.length;

// Print results
console.log("Generated Numbers:", numbers);
console.log("Sum:", sum);
console.log("Average:", average.toFixed(2)); // Rounded to 2 decimal places
