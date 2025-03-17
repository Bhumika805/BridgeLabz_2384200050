function isPalindrome(num) {
    let str = num.toString();
    let reversedStr = str.split("").reverse().join("");
    return str === reversedStr;
}

// Example usage
let num1 = 121, num2 = 123;
console.log(`${num1} is palindrome: ${isPalindrome(num1)}`);
console.log(`${num2} is palindrome: ${isPalindrome(num2)}`);
