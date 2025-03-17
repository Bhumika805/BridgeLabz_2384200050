const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

//  Problem 1: Convert Single Digit to Word
function singleDigitToWord() {
    rl.question("Enter a single digit number (0-9): ", (numInput) => {
        const num = parseInt(numInput);
        let word = "";

        if (num === 0) word = "Zero";
        else if (num === 1) word = "One";
        else if (num === 2) word = "Two";
        else if (num === 3) word = "Three";
        else if (num === 4) word = "Four";
        else if (num === 5) word = "Five";
        else if (num === 6) word = "Six";
        else if (num === 7) word = "Seven";
        else if (num === 8) word = "Eight";
        else if (num === 9) word = "Nine";
        else word = "Invalid Input!";

        console.log("Number in Words:", word);
        dayOfWeek(); // Call next function
    });
}

//  Problem 2: Display Weekday Name
function dayOfWeek() {
    rl.question("Enter a number (1-7) to get the weekday: ", (dayInput) => {
        const day = parseInt(dayInput);
        let weekday = "";

        if (day === 1) weekday = "Sunday";
        else if (day === 2) weekday = "Monday";
        else if (day === 3) weekday = "Tuesday";
        else if (day === 4) weekday = "Wednesday";
        else if (day === 5) weekday = "Thursday";
        else if (day === 6) weekday = "Friday";
        else if (day === 7) weekday = "Saturday";
        else weekday = "Invalid Input!";

        console.log("Day:", weekday);
        numberPlaceValue(); // Call next function
    });
}

//  Problem 3: Number Place Value (Unit, Ten, Hundred, etc.)
function numberPlaceValue() {
    rl.question("Enter a number (1,10,100,1000, etc.): ", (numInput) => {
        const num = parseInt(numInput);
        let place = "";

        if (num === 1) place = "Unit";
        else if (num === 10) place = "Ten";
        else if (num === 100) place = "Hundred";
        else if (num === 1000) place = "Thousand";
        else if (num === 10000) place = "Ten Thousand";
        else if (num === 100000) place = "Lakh";
        else place = "Invalid Input!";

        console.log("Place Value:", place);
        arithmeticOperations(); // Call next function
    });
}

//  Problem 4: Perform Arithmetic Operations & Find Min/Max
function arithmeticOperations() {
    rl.question("Enter three numbers (a b c): ", (input) => {
        const [a, b, c] = input.split(" ").map(Number);

        let result1 = a + b * c;
        let result2 = a % b + c;
        let result3 = c + a / b;
        let result4 = a * b + c;

        let max = result1, min = result1;

        if (result2 > max) max = result2;
        else if (result2 < min) min = result2;

        if (result3 > max) max = result3;
        else if (result3 < min) min = result3;

        if (result4 > max) max = result4;
        else if (result4 < min) min = result4;

        console.log("Results:", result1, result2, result3, result4);
        console.log("Maximum Value:", max);
        console.log("Minimum Value:", min);

        rl.close();
    });
}

// Start Execution
singleDigitToWord();
