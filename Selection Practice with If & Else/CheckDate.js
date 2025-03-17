// Get command-line arguments
const args = process.argv.slice(2); // Ignore first two arguments (node & script name)

// Convert inputs to numbers
const month = parseInt(args[0]); // First argument is month
const day = parseInt(args[1]);   // Second argument is day

// Validate input
if (isNaN(month) || isNaN(day) || month < 1 || month > 12 || day < 1 || day > 31) {
    console.log("Invalid input. Please enter a valid month (1-12) and day (1-31).");
} else {
    // Check if the date is within the given range
    let isValid = false;

    if ((month === 3 && day >= 20) ||  // March 20 to March 31
        (month === 4 && day >= 1 && day <= 30) ||  // Full April
        (month === 5 && day >= 1 && day <= 31) ||  // Full May
        (month === 6 && day >= 1 && day <= 20)) {  // June 1 to June 20
        isValid = true;
    }

    // Print the result
    console.log(isValid);
}