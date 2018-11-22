  //Projeto:  Controle de travas por biometria.
//Desenvolvido no ano de 2018
//Autor: Marinho Santana
//Formação: Tecnico em Eletrônica e Tecnico em Informatica.
//Todos direitos reservados

#include <Adafruit_Fingerprint.h>
#include <EEPROM.h>
#include <SoftwareSerial.h>
//#if ARDUINO >= 1000
//#else
//#endif

// declarção de variáveis para leitor biometrico
int getFingerprintIDez();
uint8_t getFingerprintEnroll(uint8_t id);
uint8_t getFingerprintEnroll(int id);

// pin 52 fio verde do sensor - 53 fio branco 
SoftwareSerial mySerial(52,53); 
Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

int ebox[16] = {
  22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37};
int sensor_ebox[16]={
  A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15};
char enrolid[2]={
  '0','0'};//variavelpara guadar o id do usuario
  
const int fault_sensor = 8; 
const int alarm_ebox = 9;
const int audioPin = 10; 
const int led_blue = 11;
const int led_green = 12;     
const int led_red = 13;  
const int maxx = 17;        // aqui define a qtde de armarios

int id;
int count = 0;         // variavel para contar qtde de amario usados
int getEnrol = 0;
int num_ebox = NULL;
boolean fechado = false;
boolean aberto = false;
boolean alarm = false;

void setup()
{ 
  Serial.begin(9600); //incia serial 
  finger.begin(57600); //taxa de comunicacao do leitor
  pinMode(fault_sensor,OUTPUT);
  pinMode(audioPin,OUTPUT);    
  pinMode(alarm_ebox,OUTPUT);  
  pinMode(led_blue,OUTPUT);
  pinMode(led_green,OUTPUT);
  pinMode(led_red,OUTPUT);

  for(int i = 0; i< maxx; i++){
    pinMode(ebox[i],OUTPUT);   
    digitalWrite(ebox[i],HIGH); 
  }  
  //verifica se leitor esta conectado ou nao 
  if (finger.verifyPassword()) {
    Serial.write("LEITOR BIOMETRICO FUNCIONANDO.");
    digitalWrite(fault_sensor, LOW);
  } 
  else {
    Serial.write("LEITOR BIOMETRICO NAO ESTA FUNCIONANDO.");
    digitalWrite(fault_sensor, HIGH);
    delay(1000);
    // while (1)
    inicio();
    //asm volatile ("  jmp 0");//reinicia automaticamente
  } 
}

void loop()
{  
  if(getEnrol == 1){
    getFingerprintIDez();
  }
//  int val = analogRead(sensor_ebox[9-1]);
//  Serial.print(val);
//  Serial.print("-");
//  delay(3000);

  if(Serial.available() > 0){
    // Enquanto receber algo pela serial
    while(Serial.available() > 0) {
      // Lê byte da serial
      char recebido = Serial.read();
      switch(recebido){

      case 'A':      
        digitalWrite(ebox[0], LOW);
        aberto = true;
        num_ebox = 0;
       // Serial.println(" recebi E1");
        break;

      case 'B':       
        digitalWrite(ebox[1], LOW);
        aberto = true;
        num_ebox = 1;
        //Serial.println(" recebi E2");
        break;

      case 'C':
        digitalWrite(ebox[2], LOW);
        aberto = true;
        num_ebox = 2;
        //Serial.println(" recebi E3");
        break;

      case 'D':
        digitalWrite(ebox[3], LOW);
        aberto = true;
        num_ebox = 3;
        //Serial.println(" recebi E4");
        break;

      case 'E':
        digitalWrite(ebox[4], LOW);
        aberto = true;
        num_ebox = 4;
       // Serial.println(" recebi E5");
        break; 

      case 'F':
        digitalWrite(ebox[5], LOW);
        aberto = true;
        num_ebox = 5;
       // Serial.println(" recebi E6");
        break;

      case 'G':
        digitalWrite(ebox[6], LOW);
        aberto = true;
        num_ebox = 6;
        //Serial.println(" recebi E7");
        break;

      case 'H':
        digitalWrite(ebox[7], LOW);
        aberto = true;
        num_ebox = 7;
        //Serial.println(" recebi E8");
        break;

      case 'I':
        digitalWrite(ebox[8], LOW);
        aberto = true;
        num_ebox = 8;
       // Serial.println(" recebi E9");
        break;

      case 'J':
        digitalWrite(ebox[9], LOW);
        aberto = true;
        num_ebox = 9;
        //Serial.println(" recebi E10");
        break;

      case 'K':
        digitalWrite(ebox[10], LOW);
        aberto = true;
        num_ebox = 10;
        //Serial.println(" recebi E11");
        break;

      case 'L':
        digitalWrite(ebox[11], LOW);
        aberto = true;
        num_ebox = 11;
       // Serial.println(" recebi E12");
        break;

      case 'M':
        digitalWrite(ebox[12], LOW);
        aberto = true;
        num_ebox = 12;
        //Serial.println(" recebi E13");
        break;

      case 'N':
        digitalWrite(ebox[13], LOW);
        aberto = true;
        num_ebox = 13;
        //Serial.println(" recebi E14");
        break;

      case 'O':
        digitalWrite(ebox[14], LOW);
        aberto = true;
        num_ebox = 14;
       // Serial.println(" recebi E15");
        break;

      case 'P':
        digitalWrite(ebox[15], LOW);
        aberto = true;
        num_ebox = 15;
       // Serial.println(" recebi E16");
        break;
         //apaga todas biometrias
        case '?':       
        fechado = true;
        break;
       //chama funcao para abrir todos compartimentos   
        case '%':       
        Abrir_Todos();
        break;
        
      case '@':
      //habilita leitor biometrico para leitura de digitais
        getEnrol = 1;
        break;
        //apaga todas biometrias
        case '#':       
        Delete_biometria();
        break;

      default:
        enrolid[count] = recebido;
        count +=1;
        if(count == 2){
         id = atoi(enrolid);
         count = 0;  
         getFingerprintEnroll();
        }
        break;
      }
    }
      delay(3000); 
  }
  //---------------------------------------------------- 

  if(aberto){
    int val = analogRead(sensor_ebox[num_ebox]);
    if(val > 100)
    {    
      //delay(3000);   
      Serial.println("ABERTO");
      digitalWrite(led_green,HIGH);
      digitalWrite(led_red,LOW);      
      aberto = false;
      delay(1000);
      digitalWrite(ebox[num_ebox],HIGH);
      delay(2000);
    }
    else
    {  
      //delay(3000);       
      Serial.println("ERRO"); 
      digitalWrite(ebox[num_ebox],HIGH);
      aberto = false;
      num_ebox = NULL;
    } 
  }

  if(fechado){
    int val = analogRead(sensor_ebox[num_ebox]);
    if(val < 50){    
      //delay(3000);      
      Serial.println("FECHADO");
      digitalWrite(led_green,LOW);
      digitalWrite(led_red,HIGH);
      fechado = false;
      num_ebox = NULL;
    }
    else
    {
      delay(3000);  
      Serial.println("ERRO"); 
      digitalWrite(ebox[num_ebox],HIGH);
      fechado = false;
    }
  }
}//loop

//***************converte string para inteiro*************************************

int getInt(String string)
{
  int Numero = string.length() + 1;
  char buffer[Numero];
  string.toCharArray(buffer, Numero);
  int number = atoi(buffer);
  return number;
}

//**********trata dados da serial recebido do pc c#*********************8
//***********esse trava leitor biometrico*****************************

String readStringSerial()
{
  String conteudo = "";
  char caractere;  
  // Enquanto receber algo pela serial
  while(Serial.available() > 0) {   
    caractere = Serial.read();
    // Ignora caractere de quebra de linha
    if (caractere != '\n'){
      // Concatena valores
      conteudo.concat(caractere);
    }
    // Aguarda buffer serial ler próximo caractere
    delay(10);
  }  
  return conteudo;
  Serial.println(conteudo);
}


