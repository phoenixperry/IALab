int led = 5; 
int btn = 8; 
int reading =0; 
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); 
 // pinMode(led, OUTPUT); 
  pinMode(btn, INPUT_PULLUP); 
  pinMode(led, OUTPUT); 
}

void loop() {
  // put your main code here, to run repeatedly:
  reading= digitalRead(btn); 
  //if(reading)digitalWrite(led, LOW);
  digitalWrite(led, HIGH); 
  Serial.println(reading); 
}
