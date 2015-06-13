void setup() {
  Serial.begin(9600);
}

void loop() {
  int sensorValue = analogRead(A0);
  Serial.print(sensorValue);
  Serial.print(", ");
  
  float v = (long(sensorValue) * 5000.0) / 1024.0;
  Serial.print(v);
  Serial.println("mV");
  
  delay(100);
}
