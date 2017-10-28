/* Arduino USB Keyboard HID demo
 * Volume+/Volume-/Mute keys
 */

uint8_t buf[8] = { 
  0 };   /* Keyboard report buffer */

#define PIN_UP 5
#define PIN_DOWN 6
#define PIN_RIGHT 7 
#define PIN_LEFT 8 

int state = 1;

void setup() 
{
  Serial.begin(9600);
  pinMode(PIN_UP, INPUT);
  pinMode(PIN_DOWN, INPUT);
  pinMode(PIN_RIGHT, INPUT);
  pinMode(PIN_LEFT, INPUT); 
  // enable internal pull-ups
  digitalWrite(PIN_UP, 1); 
  digitalWrite(PIN_DOWN, 1); 
  digitalWrite(PIN_LEFT, 1); 
  digitalWrite(PIN_RIGHT, 1); 
}

void loop() 
{
  int state = digitalRead(PIN_UP);
  Serial.print("Up: "); 
  Serial.println(state);

    state = digitalRead(PIN_DOWN);
  Serial.print("down: "); 
  Serial.println(state);

    state = digitalRead(PIN_LEFT);
  Serial.print("LEFT: "); 
  Serial.println(state);

    state = digitalRead(PIN_RIGHT);
  Serial.print("RIGHT: "); 
  Serial.println(state);
  state = digitalRead(PIN_DOWN);
  delay(100); 

}

