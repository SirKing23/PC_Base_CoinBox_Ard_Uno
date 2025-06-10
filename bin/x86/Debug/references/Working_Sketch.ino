const int coinPin = 13;  
const int optoPin = 7;  // Arduino digital pin connected to the optocoupler's LED


volatile unsigned int coinCount = 0;
unsigned long lastCoinTime = 0;
unsigned long debounceDelay = 50;  // Adjust this if you're getting false triggers

void setup() {
  pinMode(coinPin, INPUT);
  attachInterrupt(digitalPinToInterrupt(coinPin), coinInserted, RISING);
  pinMode(optoPin, OUTPUT); //para sa relay
digitalWrite(optoPin, LOW);   // Turn off the optocoupler's LED
  Serial.begin(9600);
}

void loop() {
    //code para basahin ang inserted coins
  static unsigned int lastPrintedCount = 0;
  if (coinCount != lastPrintedCount) {
      Serial.println(coinCount);
    lastPrintedCount = coinCount;
   }
  
}

void coinInserted() {
  unsigned long currentTime = millis();
  
  // Debounce the signal
  if (currentTime - lastCoinTime >= debounceDelay) {
    coinCount++;
    lastCoinTime = currentTime;
  }
}
