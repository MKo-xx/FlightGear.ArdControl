unsigned long duration;

void setup() {                
  Serial.begin(9600);
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);   
}

void loop() {
  duration = pulseIn(2, HIGH, 30000);
  Serial.print(duration, DEC); 
  Serial.print(",");
  
  duration = pulseIn(3, HIGH, 30000);
  Serial.print(duration, DEC);
  Serial.print(",");
  
  duration = pulseIn(4, HIGH, 30000);
  Serial.print(duration, DEC);  
  Serial.println("");
  
  delay(100);
}
