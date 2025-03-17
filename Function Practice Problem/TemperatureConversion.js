function convertTemperature(value, scale) {
    switch (scale.toLowerCase()) {
        case 'c': // Convert Fahrenheit to Celsius
            if (value < 32 || value > 212) {
                console.log("Temperature must be between Freezing (32°F) and Boiling (212°F).");
                return;
            }
            let degC = (value - 32) * (5 / 9);
            console.log(`${value}°F is ${degC.toFixed(2)}°C`);
            break;

        case 'f': // Convert Celsius to Fahrenheit
            if (value < 0 || value > 100) {
                console.log("Temperature must be between Freezing (0°C) and Boiling (100°C).");
                return;
            }
            let degF = (value * 9 / 5) + 32;
            console.log(`${value}°C is ${degF.toFixed(2)}°F`);
            break;

        default:
            console.log("Invalid scale. Use 'C' for Celsius and 'F' for Fahrenheit.");
    }
}

// Example usage
convertTemperature(100, 'C'); // 100°F to Celsius
convertTemperature(0, 'F');   // 0°C to Fahrenheit
