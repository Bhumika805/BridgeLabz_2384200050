// Unit Conversion Script

// a. Convert 42 inches to feet
function inchesToFeet(inches) {
    return inches / 12;
}
let inches = 42;
console.log(`42 inches = ${inchesToFeet(inches).toFixed(2)} feet`);

// b. Convert rectangular plot dimensions from feet to meters
function feetToMeters(feet) {
    return feet * 0.3048;
}
let lengthFeet = 60, widthFeet = 40;
let lengthMeters = feetToMeters(lengthFeet);
let widthMeters = feetToMeters(widthFeet);
console.log(`Plot dimensions: ${lengthFeet}ft x ${widthFeet}ft = ${lengthMeters.toFixed(2)}m x ${widthMeters.toFixed(2)}m`);

// c. Calculate area of 25 plots in acres
function calculateTotalAreaInAcres(plots, lengthMeters, widthMeters) {
    let areaMeters = lengthMeters * widthMeters;
    let totalAreaMeters = areaMeters * plots;
    return totalAreaMeters * 0.000247105; // 1 sq. meter = 0.000247105 acres
}
let totalAcres = calculateTotalAreaInAcres(25, lengthMeters, widthMeters);
console.log(`Total area of 25 plots in acres: ${totalAcres.toFixed(4)} acres`);
