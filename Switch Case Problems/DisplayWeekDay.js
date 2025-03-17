// Get the command-line argument
const args = process.argv.slice(2);
const dayNum = parseInt(args[0]); // Convert input to an integer

// Use switch-case to map numbers to weekdays
switch (dayNum) {
    case 1: console.log("Sunday"); break;
    case 2: console.log("Monday"); break;
    case 3: console.log("Tuesday"); break;
    case 4: console.log("Wednesday"); break;
    case 5: console.log("Thursday"); break;
    case 6: console.log("Friday"); break;
    case 7: console.log("Saturday"); break;
    default: console.log("Invalid input. Enter a number between 1 and 7.");
}
