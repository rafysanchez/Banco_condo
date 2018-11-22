
//inicio do sistema
void inicio(){
  Serial.println(""); 
  digitalWrite(led_red,HIGH);
  digitalWrite(led_blue,LOW);
  digitalWrite(led_green,LOW);
  digitalWrite(alarm_ebox,LOW);
  getEnrol = 0;
  //verifica se leitor esta conectado ou nao 
  if (finger.verifyPassword())
  {
    digitalWrite(fault_sensor, LOW);
  } 
  else 
  {        
    digitalWrite(fault_sensor, HIGH);
    delay(1000);
  }
  // gera tom audível
  tone(audioPin, 1080, 100);
  delay(300);
  noTone(audioPin);
  tone(audioPin, 980, 100);
  delay(200);
  noTone(audioPin);
  tone(audioPin, 770, 100);
  delay(300);
  noTone(audioPin); 
}

//********** Aguardando acao usuario ******************************* 

void code_entry_init(){
  
  // gera sinal audível
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  tone(200, 1500, 100);
  delay(250);
  noTone(audioPin);
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  // somente LED azul aceso
  digitalWrite(led_red, LOW);
  digitalWrite(led_blue, HIGH);
  digitalWrite(led_green, LOW);
}
//********************FUNCAO PARA ABRIR TODOS COMPARTIMENTOS********************************************

void Abrir_Todos()
{
  for(int x = 0; x < 16; x++ ){
  digitalWrite(ebox[x],LOW);
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  delay(500);
  }
  delay(5000);
  for(int j=0; j<16; j++){
  digitalWrite(ebox[j],HIGH);
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  delay(500);
  }
}

//************** cadastros de novas biometrias *****************************

uint8_t getFingerprintEnroll() { 
  
  //gera som audivel
  code_entry_init(); 
  
   delay(2000);
   Serial.println("\n"); 
Serial.println("CADASTRO DE BIOMETRIA"); 
  delay(2000);
  int p = -1;  
     Serial.println("\n"); 
  Serial.println("PRESSIONE O DEDO NO SENSOR.");  
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:    
      Serial.println("\n"); 
      Serial.println("IMAGEM SALVA.");
      break;
    case FINGERPRINT_NOFINGER:
      break;
    case FINGERPRINT_PACKETRECIEVEERR:      
    Serial.println("\n"); 
      Serial.println("ERRO NA COMUNICAÇÃO COM ARDUINO.");
      break;
      delay(2000);
      inicio();// inicializa 
    case FINGERPRINT_IMAGEFAIL:
     Serial.println("\n"); 
      Serial.println("ERRO NA CAPTURA DA IMAGEM.");
      break;            
      delay(2000);
      inicio();// inicializa 
    default:
      Serial.println("\n"); 
     Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");      
      break;            
      delay(2000);
      inicio();// inicializa  
    }
  }
  // OK success!

  p = finger.image2Tz(1);
  switch (p) {
  case FINGERPRINT_OK:
   Serial.println("\n"); 
    Serial.println("IMAGEM SALVA.");
    break;
  case FINGERPRINT_IMAGEMESS:
   Serial.println("\n"); 
   Serial.println("IMAGEM CONFUSA.");
    inicio();// inicializa  
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
 Serial.println("\n"); 
  Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");   
    delay(2000);
    inicio();// inicializa   
    return p;

  case FINGERPRINT_FEATUREFAIL:
Serial.println("\n"); 
   Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa  
    return p;
  case FINGERPRINT_INVALIDIMAGE:
   Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa  
    return p;
  default:
  Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    delay(2000);
    inicio();// inicializa 
    return p; 
  }
 Serial.println("\n"); 
  Serial.println("REMOVA O DEDO.");
  delay(2000);
  ////////////////////////////////////////
  p = 0;
  while (p != FINGERPRINT_NOFINGER) {
    p = finger.getImage();
  }
  p = -1;  
 Serial.println("\n"); 
  Serial.println("COLOQUE O MESMO DEDO NOVAMENTE.");
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:
     Serial.println("\n"); 
     Serial.println("IMAGEM SALVA.");
      break;
    case FINGERPRINT_NOFINGER:
      break;
    case FINGERPRINT_PACKETRECIEVEERR:
     Serial.println("\n"); 
     Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");    
      break;            
      delay(2000);
      inicio();// inicializa 
    case FINGERPRINT_IMAGEFAIL:
    Serial.println("\n"); 
     Serial.println("ERRO DE BIOMETRIA.");
      break;            
      delay(2000);
      inicio();// inicializa 
    default:
      Serial.println("\n"); 
      Serial.println("ERRO DESCONHECIDO.");
      break;            
      delay(2000);
      inicio();// inicializa 
    }
  }

  // OK success!

  p = finger.image2Tz(2);
  switch (p) {
  case FINGERPRINT_OK:
Serial.println("\n"); 
   Serial.println("IMAGEM CONVERTIDA.");
    break;          
  case FINGERPRINT_IMAGEMESS:
  Serial.println("\n"); 
Serial.println("IMAGEM CONFUSA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
   Serial.println("\n"); 
Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");
    delay(2000);
    inicio();// inicializa 
    return p;

  case FINGERPRINT_FEATUREFAIL:
   Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_INVALIDIMAGE:   
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");  
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");    
    delay(2000);
    inicio();// inicializa 
    return p; 
  }
  // OK converted!
  p = finger.createModel();
  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("IMAGEM SALVA.");
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
Serial.println("\n"); 
   Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");        
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_ENROLLMISMATCH) {
 Serial.println("\n"); 
   Serial.println("DIGITAIS DIFERENTES.");
    delay(2000);
    inicio();// inicializa  
    return p;

  } 
  else {
  Serial.println("\n"); 
   Serial.println("ERRO DESCONHECIDO.");  
    delay(2000);
    inicio();// inicializa 
    return p;
  }   
  p = finger.storeModel(id);
  if (p == FINGERPRINT_OK) {
   Serial.println("\n"); 
    Serial.println("USUARIO CADASTRADO COM SUCESSO.");
   Serial.println("\n"); 
    delay(2000);
    Serial.println(id);
    delay(2000);

    //"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
   Serial.println("\n"); 
   Serial.println("ERRO DE BIOMETRIA.");    
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO ARMAZENAR.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_FLASHERR) {
   Serial.println("\n"); 
  Serial.println("FALHA AO ARMAZENAR.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");    
    delay(2000);
    inicio();// inicializa 
    return p;
  }  
  inicio();// inicializa 
}//fecha funcao enrol

//************ Verificacao de biometrias *******************************

uint8_t getFingerprintID() {
  
  //gera som audivel
  code_entry_init(); 
  
  uint8_t p = finger.getImage();
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM DETECTADA.");
    break;
  case FINGERPRINT_NOFINGER:
    Serial.println("\n"); 
    Serial.println("BIOMETRIA AUTENTICADA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");      
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_IMAGEFAIL:
    Serial.println("\n"); 
    Serial.println("ERRO DE IMAGEM.");    
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    delay(2000);
    inicio();// inicializa 
    return p;
  }

  // OK success!

  p = finger.image2Tz();
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONVERTIDO.");
    break;
  case FINGERPRINT_IMAGEMESS:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONFUSA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO DE COMUNICAÇÃO COM LEITOR BIOMETRICO.");       
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_FEATUREFAIL:
    Serial.println("\n"); 
    Serial.println("FALHA NA BIOMETRIA.");  
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_INVALIDIMAGE:
    Serial.println("\n"); 
    Serial.println("FALHA NA BIOMETRIA.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");    
    delay(2000);
    inicio();// inicializa 
    return p; 
  }

  // OK converted!
  p = finger.fingerFastSearch();
  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("BIOMETRIA ENCONTRADA.");
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO");
    delay(2000);
    inicio();// inicializa 
    return p; 
  } 
  else if (p == FINGERPRINT_NOTFOUND) {
    Serial.println("\n"); 
    Serial.println("ACESSO NEGADO!");
    tone(audioPin, 1000, 100);
    delay(200);
    noTone(audioPin);
    //*******************************************************************
    for(int i = 0; i<4; i++)
    {

    }    
    delay(1000);
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  }   

  // found a match!
  Serial.println("\n"); 
  Serial.println("ID ENCONTRADO.");
  Serial.println(finger.confidence); 
}

// returns -1 if failed, otherwise returns ID #
//retorna -1 se falhar, caso contrÃ¡rio retorna ID
int getFingerprintIDez() {
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK) return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK){  
    Serial.println("\n"); 
    Serial.println("ERRO DE LEITURA.");
    inicio();// inicializa 
    return -1;
  }

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK){
    Serial.println("\n"); 
    Serial.println("ACESSO NEGADO!");
    tone(audioPin, 1000, 100);
    delay(200);
    noTone(audioPin);
    //*******************************************************************
    for(int i = 0; i<4; i++)
    {     
      //
    } 
    delay(1000);   
    inicio();// inicializa 
    return -1;
  }
  // found a match!
  //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

 // Serial.println("\n"); 
 // Serial.println("ACESSO PERMITIDO.");  
  int id_user = finger.fingerID;
  tone(audioPin, 3000, 1000);
  delay(200);
  noTone(audioPin);
  delay(300);
  tone(audioPin, 3000, 1500);
  delay(200);
  noTone(audioPin);
  delay(2000);
  //Serial.println("\n"); 
  Serial.println(id_user);
  delay(5000);
  inicio();// inicializa 
}

//""""""""""" funcao para deletar biometrias""""""""""""""""""""""""""""""""""""""""""""""""""""""

uint8_t deleteFingerprint() {  

  int id ;//= enrolid;

  uint8_t p = -1;

  p = finger.deleteModel(id);

  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("EXCLUSÃO DE USUARIO.");
    Serial.println(id);  
    delay(1000);
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE COMUNICAÇÃO COM LEITOR BIOMETRICO."); 
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO EXCLUIR.");
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE FLASH.");
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    return p;
    delay(2000);
    inicio();// inicializa 
  }  

  inicio();// inicializa 
}//fecha funcao dele


//""""""""""" funcao para deletar biometrias""""""""""""""""""""""""""""""""""""""""""""""""""""""
void Delete_biometria()
{
  for(int i=0; i<16; i++){
     deleteFingerprintID(i);
  }
}

uint8_t deleteFingerprintID(int user) {  
  //gera som audivel
  code_entry_init(); 
  
  int id = user;

  uint8_t p = -1;

  p = finger.deleteModel(id);

  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("EXCLUIR USUARIO PELO ID.");
    Serial.println(id);  
    Serial.println("\n"); 
    Serial.println("POR FAVOR AGUARDE...");
    // return 2;//retorna valor para o lcaço
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");
    delay(2000);
    return p;

  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO EXCLUIR.");
    delay(2000);
    return p;
  } 
  else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE FLASH.");
    delay(2000);
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    delay(2000);
    return p;
  }  
}  //fecha funcao deleT

 // Look for new cards
  //if ( ! mfrc522.PICC_IsNewCardPresent()) {
  //  return;
 // }
  // Select one of the cards
  //if ( ! mfrc522.PICC_ReadCardSerial()) {
  //  return;
  //}
  // Dump debug info about the card. PICC_HaltA() is automatically called.
  //mfrc522.PICC_DumpToSerial(&(mfrc522.uid));
  //String conteudo = "";
  //for(byte i = 0; i < mfrc522.uid.size; i++)
  //  conteudo.concat(String(mfrc522.uid.uidByte[i], HEX));  
 // Serial.println(conteudo);
