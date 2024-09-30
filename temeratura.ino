#include <SoftwareSerial.h>

SoftwareSerial BTSerial(10, 11); // RX, TX

float temperatura;
int sensor;
int sensorPin = A0;

void setup() {
  Serial.begin(9600);
  BTSerial.begin(9600);
}

void loop() {

  sensor = analogRead(A0);
  temperatura = ((sensor * 5000.0) / 1023) / 10;

  Serial.print("Temperatura: ");
  Serial.println(temperatura);
  BTSerial.println(temperatura); 
  
  delay(1000);
 
}
