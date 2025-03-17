// Get the command-line argument
const args = process.argv.slice(2);
const n = parseInt(args[0]);

// Validate input
if (isNaN(n) || n < 0) {
    console.log("Enter a valid non-negative integer.");
} else {
    console.log(`Table of powers of 2 up to 2^${n}:`);
    for (let i = 0; i <= n; i++) {
        console.log(`2^${i} = ${Math.pow(2, i)}`);
    }
}
