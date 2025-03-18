// Function to roll a die (returns a random number between 1 and 6)
const rollDice = () => Math.floor(Math.random() * 6) + 1;

// Create a Map to store dice roll counts
let diceRolls = new Map();

// Initialize the map with all numbers 1-6 set to 0
for (let i = 1; i <= 6; i++) {
    diceRolls.set(i, 0);
}

// Roll the die until any number appears 10 times
let maxRoll = 10;
let found = false;

console.log("Rolling the dice...");

// (b) Repeat the Die roll and find the result each time
while (!found) {
    let roll = rollDice();
    diceRolls.set(roll, diceRolls.get(roll) + 1); // Update count

    // Print each roll result
    console.log(`Rolled: ${roll}, Updated Count:`, Object.fromEntries(diceRolls));

    // (d) Check if any number has reached 10 times
    if (diceRolls.get(roll) === maxRoll) {
        found = true;
    }
}

// (e) Find the number that reached maximum times and the one that was for minimum times
let maxValue = Math.max(...diceRolls.values());
let minValue = Math.min(...diceRolls.values());

let maxNumber = [], minNumber = [];

// Iterate through map to find numbers with max and min occurrences
for (let [key, value] of diceRolls.entries()) {
    if (value === maxValue) {
        maxNumber.push(key);
    }
    if (value === minValue) {
        minNumber.push(key);
    }
}

// Print final results
console.log("\n=== Final Dice Roll Counts ===");
console.log(Object.fromEntries(diceRolls));
console.log(`\nNumber that reached 10 times: ${maxNumber.join(", ")}`);
console.log(`Number that appeared the least times: ${minNumber.join(", ")}`);
