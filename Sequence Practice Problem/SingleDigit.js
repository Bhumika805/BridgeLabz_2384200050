const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Press Enter to generate a random single digit (0-9): ", () => {
    let randomDigit = Math.floor(Math.random() * 10);
    console.log("Random Single Digit:", randomDigit);
    rl.close();
});
