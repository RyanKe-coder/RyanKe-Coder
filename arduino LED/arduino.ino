
void setup()
{
   for (int i = 9; i < 12; i ++) 
   {
     pinMode(i, OUTPUT);
   }
}
void loop()
{
   for (int count = 9; i < 12; i ++) 
   {
     digitalWrite(i, LOW);        
     delay(800);
   }
   for (int count = 9; i < 12; i ++) 
   {
     digitalWrite(i, HIGH);
     delay(800);
   }  
 
}