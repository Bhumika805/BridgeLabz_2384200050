// Get the command-line argument
const args = process.argv.slice(2);
const num = parseInt(args[0]);

// Validate input
if (isNaN(num) || num < 2) {
    console.log("Enter a valid integer greater than 1.");
} else {
    let isPrime = true;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            isPrime = false;
            break;
        }
    }
    console.log(num + (isPrime ? " is a Prime Number." : " is NOT a Prime Number."));
}
