// Get the command-line argument
const args = process.argv.slice(2);
const number = parseInt(args[0]); // Convert input to an integer

// Use switch-case to map numbers to place values
switch (number) {
    case 1: console.log("Unit"); break;
    case 10: console.log("Ten"); break;
    case 100: console.log("Hundred"); break;
    case 1000: console.log("Thousand"); break;
    case 10000: console.log("Ten Thousand"); break;
    default: console.log("Invalid input. Enter 1, 10, 100, 1000, etc.");
}
