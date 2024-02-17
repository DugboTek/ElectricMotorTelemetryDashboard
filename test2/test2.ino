#include <SPI.h>

const int AD2S1210_SAMPLE = 7;  // Toggle to refresh data
const int AD2S1210_SDO = 12;    // Serial output from AD2S1210
const int AD2S1210_SDI = 11;    // Serial Input of AD2S1210
const int AD2S1210_SCK = 13;    // Serial clock output
const int AD2S1210_A0 = 0;      // A0 pin
const int AD2S1210_A1 = 1;      // A1 pin
const int _WR = 2;              // WR pin

#define SCLK_H digitalWrite(AD2S1210_SCK, HIGH)
#define SCLK_L digitalWrite(AD2S1210_SCK, LOW)
#define SDI_H digitalWrite(AD2S1210_SDI, HIGH)
#define SDI_L digitalWrite(AD2S1210_SDI, LOW)
#define SAMPLE_H digitalWrite(AD2S1210_SAMPLE, HIGH)
#define SAMPLE_L digitalWrite(AD2S1210_SAMPLE, LOW)
#define SDO digitalRead(AD2S1210_SDO)

void setup() {
  Serial.begin(115200);
  pinMode(AD2S1210_SAMPLE, OUTPUT);
  pinMode(AD2S1210_SDO, INPUT_PULLUP);
  pinMode(AD2S1210_SDI, OUTPUT);
  pinMode(AD2S1210_SCK, OUTPUT);
  pinMode(AD2S1210_A0, OUTPUT);
  pinMode(AD2S1210_A1, OUTPUT);
  pinMode(_WR, OUTPUT);

  SAMPLE_L;
}

void loop() {
  uint16_t position = READ_Register(0x80);
  Serial.print("Position: ");
  Serial.println(position);
  delay(200);
}

uint16_t READ_Register(uint8_t REGISTER) {
  uint16_t position;
  SAMPLE_H;
  SAMPLE_L;
  position = SPIRead(REGISTER);
  return position;
}

uint8_t SPIRead(const byte Reg) {
  uint8_t res = 0;

  digitalWrite(AD2S1210_A0, HIGH);
  digitalWrite(AD2S1210_A1, HIGH);
  digitalWrite(_WR, LOW);
  SPI.transfer(Reg);
  digitalWrite(_WR, HIGH);

  digitalWrite(_WR, LOW);
  res = SPI.transfer(0x00);
  digitalWrite(_WR, HIGH);

  digitalWrite(AD2S1210_A0, LOW);
  digitalWrite(AD2S1210_A1, LOW);

  return res;
}
