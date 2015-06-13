float lpf = 20.0;

void setup() {
  Serial.begin(9600);
  lpf = ((((long)analogRead(A0) * 5000.0) / 1024.0) - 500) / 10 - 3;
}

void loop() {
  int sensorValue = analogRead(A0);
  Serial.print(sensorValue);
  Serial.print(", ");
  
  float mv = (long(sensorValue) * 5000.0) / 1024.0;
  Serial.print(mv / 1000);
  Serial.print(", ");

  float c = (mv - 500) / 10;
  Serial.print(c);
  Serial.print(", ");
  
  lpf = (c * 0.1) + (lpf * 0.9);
  Serial.println(lpf);

  delay(100);
}
