let money = 100;
let betCount = 0;
let winCount = 0;

while (money > 0 && money < 200) {
    betCount++;

    // Simulate a bet (50% chance of winning)
    if (Math.random() < 0.5) {
        money++; // Win Rs. 1
        winCount++;
    } else {
        money--; // Lose Rs. 1
    }
}

console.log(`Game Over! Final Money: Rs. ${money}`);
console.log(`Total Bets Placed: ${betCount}`);
console.log(`Total Wins: ${winCount}`);
