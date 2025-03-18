// Function to find numbers where both digits are the same
function findRepeatedDigits() {
    let repeatedNumbers = [];

    for (let i = 10; i < 100; i++) {
        let tens = Math.floor(i / 10);
        let ones = i % 10;

        if (tens === ones) {
            repeatedNumbers.push(i);
        }
    }

    return repeatedNumbers;
}

console.log("Numbers with repeated digits:", findRepeatedDigits());
