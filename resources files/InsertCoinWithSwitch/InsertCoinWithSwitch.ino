const int coinPin = 13; // Change this to the actual pin you've connected the coin slot to
int totalAmount = 0;
const int optoPin = 7;
const int switchPin = 3; // Assuming the switch is connected to pin 3

void setup() {
  Serial.begin(9600); // Initialize serial communication for debugging
  pinMode(coinPin, INPUT_PULLUP); // Set the coin slot pin as an input with a pull-up resistor
  pinMode(optoPin, OUTPUT); // Para sa relay
  pinMode(switchPin, INPUT_PULLUP); // Set the switch pin as input with a pull-up resistor
  digitalWrite(optoPin, HIGH); // Ensure the relay is initially off
}

void loop() {
  // Code para sa pag read ng coins
  if (digitalRead(coinPin) == LOW) {
    // Debounce delay to avoid multiple readings for a single coin
    delay(50);

    // Increment total amount
    totalAmount++;
    Serial.println(totalAmount);

    // Additional delay to prevent rapid counting
    //delay(55);
      
  }
 
  // // Check for commands over serial communication
  if (Serial.available() > 0) {
    char command = Serial.read();

    // Handle the command
    switch (command) {
      case 'F':
        // Perform Relay Enabled
        totalAmount = 0; // Reset totalAmount
        digitalWrite(optoPin, HIGH); // Turn off the optocoupler's LED
        break;
      case 'T':
        // Perform Relay Disabled
        digitalWrite(optoPin, LOW); // Turn on the optocoupler's LED
        break;
      default:
        // Unknown command, handle appropriately
        break;
    }

    // Delay after reading the command to avoid rapid looping
    delay(100);
  }

  //Check if the switch is pressed
  // if (digitalRead(switchPin) == LOW) {
  //   // Send -1 value over serial
  //   Serial.println(-1);

  //   // Add a delay to avoid sending multiple times when the switch is pressed
  //   delay(500);

  // }
}
