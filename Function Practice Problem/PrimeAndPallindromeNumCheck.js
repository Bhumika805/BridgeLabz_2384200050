// Function to check if a number is prime
function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// Function to get palindrome of a number
function getPalindrome(num) {
    return parseInt(num.toString().split("").reverse().join(""));
}

// Main function
function checkPrimeAndPalindrome(num) {
    if (!isPrime(num)) {
        console.log(`${num} is NOT a prime number.`);
        return;
    }

    console.log(`${num} is a prime number.`);

    let palindromeNum = getPalindrome(num);
    console.log(`Palindrome of ${num} is ${palindromeNum}.`);

    if (isPrime(palindromeNum)) {
        console.log(`Palindrome ${palindromeNum} is also a prime number.`);
    } else {
        console.log(`Palindrome ${palindromeNum} is NOT a prime number.`);
    }
}

// Example usage
checkPrimeAndPalindrome(13);
checkPrimeAndPalindrome(101);
