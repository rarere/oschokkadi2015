void setup() {
  Serial.begin(9600);
}

void loop() {
  int sensorValue = analogRead(A0);
  Serial.print(sensorValue);
  Serial.print(", ");
  
  float mv = (long(sensorValue) * 5000.0) / 1024.0;
  Serial.print(mv);
  Serial.print("mV, ");
  
  float c = (mv - 500) / 10;
  Serial.print(c);
  Serial.println("C");
  
  delay(500);
}
