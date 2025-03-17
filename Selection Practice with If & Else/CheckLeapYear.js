const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Enter a 4-digit year: ", (yearInput) => {
    const year = parseInt(yearInput);

    if (isNaN(year) || year < 1000 || year > 9999) {
        console.log("Please enter a valid 4-digit year.");
    } else {
        const isLeapYear = (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
        console.log(isLeapYear ? `${year} is a Leap Year.` : `${year} is NOT a Leap Year.`);
    }

    rl.close();
});
