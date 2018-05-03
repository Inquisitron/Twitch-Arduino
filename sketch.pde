const int pinY = 14;
const int pinG = 15;
const int pinR = 7;
const int pinB = 6;

bool bY = 0;
bool bG = 0;
bool bR = 0;
bool bB = 0;

void setup() {
  pinMode(pinY, OUTPUT);
  pinMode(pinG, OUTPUT);
  pinMode(pinR, OUTPUT);
  pinMode(pinB, OUTPUT);

  digitalWrite(pinY, bY);
  digitalWrite(pinG, bG);
  digitalWrite(pinR, bR);
  digitalWrite(pinB, bB);

  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    char cSelection = Serial.read();
    switch (cSelection) {
      case 'y':
      case 'Y':
        bY = !bY;
        digitalWrite(pinY, bY);
        break;
      case 'g':
      case 'G':
        bG = !bG;
        digitalWrite(pinG, bG);
        break;
      case 'r':
      case 'R':
        bR = !bR;
        digitalWrite(pinR, bR);
        break;
      case 'b':
      case 'B':
        bB = !bB;
        digitalWrite(pinB, bB);
        break;
      default:
        Serial.println(cSelection);
        break;
    }
  }
}