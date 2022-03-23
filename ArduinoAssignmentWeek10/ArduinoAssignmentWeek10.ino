#include <Display.h>

// the LEDs
const int RED = 4;
const int GREEN = 5;
const int BLUE = 6;
const int YELLOW = 7;

// the buttons
const int KEY1 = 8;
const int KEY2 = 9;

// data to measure the temperature
const int PIN_NTC = 15;
const int NTC_R25 = 10000;
const int NTC_MATERIAL_CONSTANT = 3950;

const int POTENTIOMETER = A0; // the potentiometer


// records the last states of the buttons
int lastKey1State = HIGH;
int lastKey2State = HIGH;

// records the current button states
int key1State = 0;
int key2State = 0;

int mode = 1; // will record what mode we are in
String displayLine = ""; // the line that will appear on the display in mode 1 (will always be empty upon first activation the arduino)
unsigned long lastTime; // records the last time the temperature display was updated
int interval = 0; // the interval 
int PotentioHold = 0; // will record the potentiometer position when switching out of mode 3
int mappedValue = 0; // the value of the potentiometer

void setup()
  {
    pinMode (RED, OUTPUT);
    pinMode (GREEN, OUTPUT);
    pinMode (BLUE, OUTPUT);
    pinMode (YELLOW, OUTPUT);
    pinMode (KEY1, INPUT_PULLUP);
    pinMode (KEY2, INPUT_PULLUP);
    pinMode(POTENTIOMETER, INPUT);
    Serial.begin(9600);
    lastTime = millis();

    // setting the initial value of the potentiometer after first entering the application
    int valuePot = analogRead(POTENTIOMETER);
    int mappedValue = map(valuePot, 0, 1023, 0, 30);
    PotentioHold = mappedValue;
  }

// a method that can be called on to measure the room temperature in °C
float get_temperature()
  {
    unsigned long currentTime = millis();
    if (currentTime - lastTime > interval)
      {
        lastTime = currentTime;
        interval = 5000;
        
        float temperature,resistance;
        int value;
        value = analogRead(PIN_NTC);
        resistance   = (float)value * NTC_R25/(1024 - value);
        temperature  = 1/(log(resistance/NTC_R25)/NTC_MATERIAL_CONSTANT+1/298.15)-273.15;
        return temperature;
      }
  }

// a method that will be called on when the system is in mode 1. Will display the current time
void mode1 ()
  {
    digitalWrite(YELLOW, LOW);
    digitalWrite(GREEN, HIGH);
    Display.show(displayLine);
  }

// a method that will be called on when the system is in mode 2. Will display the current temperature
void mode2 (int temp)
  {
    digitalWrite(GREEN, LOW);
    digitalWrite(BLUE, HIGH);
    Display.show(temp);
  }

// a method that will be called on when the system is in mode 3. Will display the current potentiometer position
void mode3 (int angle)
  {
    digitalWrite(GREEN, LOW);
    digitalWrite(BLUE, LOW);
    digitalWrite(YELLOW, HIGH);
    Display.show(angle);
  }

// a methods that will switch the modes if button 1 is clicked
void button1 (int btn1State)
  {
    if (btn1State == LOW)
      {
        if (mode == 1)
          {
            mode = 2;
          }
          else if (mode == 2)
            {
              mode = 3;
            }
            else if (mode == 3)
              {
                mode = 1;
                PotentioHold = mappedValue;
              }
          
        lastKey1State = LOW;
      }
      else
        {
          lastKey1State = HIGH;
        }
  }

// a method that will activate the alarm if button 2 is clicked
void button2 (int btn2State)
  {
    if (btn2State == LOW)
      {
        digitalWrite(RED, HIGH);
        Serial.println("alarm");
        lastKey1State = LOW;
      }
  }

// reads messages from C# application
void serial ()
  {
    String line = Serial.readStringUntil('\n');
    if (line == "time")
      {
        displayLine = Serial.readStringUntil('\n');
      }
      else if (line == "reset")
        {
          digitalWrite(RED, LOW);
        }
  }

void loop()
  {
    // records the current potentiometer position and automatically changes mode to 3 when the position changes
    int PotentiometerValue = analogRead(POTENTIOMETER);
    mappedValue = map(PotentiometerValue, 0, 1023, 0, 30);
    if (mappedValue != PotentioHold)
      {
        mode = 3;
      }

    // changes the modes by clicking key1
    int btn1State = digitalRead(KEY1);
    if (btn1State != lastKey1State)
    {
      button1 (btn1State);
    }

    // activates the alarm by clicking key 2
    int btn2State = digitalRead(KEY2);
    if (btn2State != lastKey1State)
      {
        button2 (btn2State);
      }

    // calls on the method serial()
    String line;
    if (Serial.available() > 0)
      {
        serial();
      }

    // records current temperature
    float celcius;
    celcius = get_temperature();
    int tempCel = celcius;
    Serial.println("temp");
    Serial.print("Room temperature ");
    Serial.print(tempCel);
    Serial.println("*C");
    if (celcius < 16)
      {
        Serial.println("below 16");
        digitalWrite(RED, HIGH);
      }
      else if (celcius > 27 && celcius < 100)
        {
          Serial.println("above 27");
          digitalWrite(RED, HIGH);
        }

    // calls on the mode methods depending on what mode the system is in
    if (mode == 1)
      {
        mode1();
      }
      else if (mode == 2)
        {
          mode2 (celcius);
        }
        else if (mode == 3)
          {
            mode3 (mappedValue);
          }
  }
