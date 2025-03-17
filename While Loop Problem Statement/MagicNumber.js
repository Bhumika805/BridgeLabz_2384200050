const readline = require("readline-sync");

// Define the range
let low = 1;
let high = 100;
let found = false;

console.log("Think of a number between 1 and 100, and I will guess it!");

while (!found) {
    let mid = Math.floor((low + high) / 2);
    let response = readline.question(`Is your number ${mid}? (yes/higher/lower): `);

    if (response.toLowerCase() === "yes") {
        console.log(`Yay! I found your magic number: ${mid}`);
        found = true;
    } else if (response.toLowerCase() === "higher") {
        low = mid + 1;
    } else if (response.toLowerCase() === "lower") {
        high = mid - 1;
    }

    if (low > high) {
        console.log("Something went wrong! Try again.");
        break;
    }
}
