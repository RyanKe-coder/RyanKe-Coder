
void setup()
{
   for (int i = 10; i < 14; i ++) 
   {
     pinMode(i, OUTPUT);
   }
}
void loop()
{
   for (int count = 10; i < 14; i ++) 
   {
     digitalWrite(i, LOW);        
     delay(800);
   }
   for (int count = BASE; i < BASE + NUM; i ++) 
   {
     digitalWrite(i, HIGH);
     delay(800);
   }  
 
}