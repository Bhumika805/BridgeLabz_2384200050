// Function to generate a random birth month (1 to 12)
const getRandomMonth = () => Math.floor(Math.random() * 12) + 1;

// Create a Map to store individuals based on birth month
let birthMonths = new Map();

// Initialize the map with empty arrays for each month
for (let i = 1; i <= 12; i++) {
    birthMonths.set(i, []);
}

// Assign 50 individuals random birth months
for (let i = 1; i <= 50; i++) {
    let month = getRandomMonth();
    birthMonths.get(month).push(i); // Add individual to corresponding month
}

// Print the individuals grouped by their birth month
console.log("Individuals grouped by Birth Month:");
for (let [month, individuals] of birthMonths.entries()) {
    if (individuals.length > 0) {
        console.log(`Month ${month}: ${individuals.join(", ")}`);
    }
}
