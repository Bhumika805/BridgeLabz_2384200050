// Function to find prime factors of a number
function primeFactors(n) {
    let factors = [];
    
    while (n % 2 === 0) {
        factors.push(2);
        n = n / 2;
    }

    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = n / i;
        }
    }

    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

// Get user input from command-line
const args = process.argv.slice(2);
const num = parseInt(args[0]);

if (!isNaN(num) && num > 1) {
    console.log("Prime Factors:", primeFactors(num));
} else {
    console.log("Please enter a valid number greater than 1.");
}
