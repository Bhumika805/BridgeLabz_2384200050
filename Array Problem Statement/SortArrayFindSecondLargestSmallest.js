// Generate 10 random 3-digit numbers
let numbers = Array.from({ length: 10 }, () => Math.floor(Math.random() * 900) + 100);
console.log("Generated Numbers:", numbers);

// Sort the array in ascending order
numbers.sort((a, b) => a - b);

console.log("Sorted Numbers:", numbers);
console.log("2nd Smallest:", numbers[1]);
console.log("2nd Largest:", numbers[numbers.length - 2]);
