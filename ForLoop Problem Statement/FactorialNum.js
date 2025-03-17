// Get the command-line argument
const args = process.argv.slice(2);
const num = parseInt(args[0]);

// Validate input
if (isNaN(num) || num < 0) {
    console.log("Enter a valid non-negative integer.");
} else {
    let factorial = 1;
    for (let i = 1; i <= num; i++) {
        factorial *= i;
    }
    console.log(`${num}! = ${factorial}`);
}
