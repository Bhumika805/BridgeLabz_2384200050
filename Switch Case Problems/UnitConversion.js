// Get command-line arguments
const args = process.argv.slice(2);
const choice = parseInt(args[0]); // Choice of conversion
const value = parseFloat(args[1]); // Value to be converted

let result;

// Use switch-case to perform unit conversion
switch (choice) {
    case 1: // Feet to Inch
        result = value * 12;
        console.log(value + " Feet = " + result + " Inches");
        break;
    case 2: // Feet to Meter
        result = value * 0.3048;
        console.log(value + " Feet = " + result + " Meters");
        break;
    case 3: // Inch to Feet
        result = value / 12;
        console.log(value + " Inches = " + result + " Feet");
        break;
    case 4: // Meter to Feet
        result = value / 0.3048;
        console.log(value + " Meters = " + result + " Feet");
        break;
    default:
        console.log("Invalid choice. Enter 1 for Feet to Inch, 2 for Feet to Meter, 3 for Inch to Feet, 4 for Meter to Feet.");
}
