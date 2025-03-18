// Function to find all triplets in an array that sum to zero
function findTriplets(arr) {
    let found = false; // Flag to check if at least one triplet is found
    let n = arr.length; // Get the length of the array
    let triplets = []; // Initialize an array to store the triplets

    // Iterate through the array with three nested loops to check all possible triplets
    for (let i = 0; i < n - 2; i++) { // First element of the triplet
        for (let j = i + 1; j < n - 1; j++) { // Second element of the triplet
            for (let k = j + 1; k < n; k++) { // Third element of the triplet
                // Check if the sum of the three numbers is zero
                if (arr[i] + arr[j] + arr[k] === 0) {
                    triplets.push([arr[i], arr[j], arr[k]]); // Store the triplet
                    found = true; // Mark that a triplet has been found
                }
            }
        }
    }

    // Return the triplets if found, otherwise return a message
    return found ? triplets : "No triplets found";
}

// Example array to test the function
let numbers = [-1, 0, 1, 2, -1, -4];

// Call the function and print the result
console.log("Triplets:", findTriplets(numbers));
