void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); 
  pinMode(4, INPUT); 
  pinMode(19, INPUT); 

}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("Hi"); 

  int leftBtn = digitalRead(4);
  int rightBtn = digitalRead(19); 
  Serial.print("left button "); 
  Serial.println(leftBtn); 
  Serial.print("right button "); 
  Serial.println(rightBtn); 
    
  delay(1000);  
  
}


