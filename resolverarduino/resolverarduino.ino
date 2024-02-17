#include <SPI.h>

// Define pin assignments
const int AD2S1210_SAMPLE = 7;   // Pin to toggle to refresh data
const int AD2S1210_SCK = 9;      // Serial clock output
const int CS_PIN = 10;           // Chip Select pin

// Variable to store the position data
uint16_t Position;

// Define macros for setting sample high/low, clock high/low
#define SAMPLE_H digitalWrite(AD2S1210_SAMPLE, HIGH)
#define SAMPLE_L digitalWrite(AD2S1210_SAMPLE, LOW)
#define SCLK_H digitalWrite(AD2S1210_SCK, HIGH)
#define SCLK_L digitalWrite(AD2S1210_SCK, LOW)

// SPI settings
SPISettings settingsA(20000000, MSBFIRST, SPI_MODE1);

void setup() {
  // Set pin modes
  pinMode(AD2S1210_SAMPLE, OUTPUT);
  pinMode(CS_PIN, OUTPUT);

  // Initialize SPI communication
  SPI.begin();
}

void loop() {
  // Read the position and print it
  Position = READ_Position();

  Serial.print("Position: ");
  Serial.println(Position);

  delay(200);  // Delay for stability
}

// Function to read the position from the AD2S1210
uint16_t READ_Position(void) {
  uint16_t position;

  // Toggle the sample pin to refresh data
  SAMPLE_H;
  SAMPLE_L;

  // Activate the AD2S1210 for communication
  digitalWrite(CS_PIN, LOW);  // Keep CS low at all times during communication

  // Read the high byte of the position
  position = AD2S1210_READ(0x80);
  position <<= 8;

  // Read the low byte of the position
  position |= AD2S1210_READ(0x81);

  // Deactivate the AD2S1210 after communication
  digitalWrite(CS_PIN, HIGH);

  return position;
}

// Function to read a byte from the AD2S1210
uint8_t AD2S1210_READ(uint8_t addr) {
  // Begin SPI communication with specified settings
  SPI.beginTransaction(settingsA);
  uint8_t temp;

  // Ensure clock is low before transmission
  SCLK_L;

  // Send the address byte to the AD2S1210
  SPI.transfer(addr);

  // Bring clock high to initiate data transfer
  SCLK_H;

  // Read the data byte from the AD2S1210
  temp = SPI.transfer(0x00);

  // Bring clock low after data transfer
  SCLK_L;

  // End SPI communication
  SPI.endTransaction();

  return temp;
}
