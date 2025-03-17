// Get the command-line argument
const args = process.argv.slice(2);
const n = parseInt(args[0]);

// Validate input
if (isNaN(n) || n <= 0) {
    console.log("Enter a valid positive integer.");
} else {
    let harmonic = 0;
    for (let i = 1; i <= n; i++) {
        harmonic += 1 / i;
    }
    console.log(`Harmonic Number H(${n}) = ${harmonic.toFixed(5)}`);
}
