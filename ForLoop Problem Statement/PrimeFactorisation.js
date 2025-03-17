// Get the command-line argument
const args = process.argv.slice(2);
let num = parseInt(args[0]);

// Validate input
if (isNaN(num) || num < 2) {
    console.log("Enter a valid integer greater than 1.");
} else {
    console.log(`Prime factors of ${num}:`);
    
    // Divide by 2 while even
    while (num % 2 === 0) {
        console.log(2);
        num /= 2;
    }

    // Check odd factors from 3 to sqrt(num)
    for (let i = 3; i <= Math.sqrt(num); i += 2) {
        while (num % i === 0) {
            console.log(i);
            num /= i;
        }
    }

    // If remaining num is prime and > 2, print it
    if (num > 2) {
        console.log(num);
    }
}
