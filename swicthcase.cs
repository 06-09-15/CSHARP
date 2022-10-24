using System;


class Program {
   public static void Main (string[] args) {
     
  /* int a,b; // declaration
  a=10; b=5; //initialization */
  int a=10, b=5;
  int exp= 1;

  //Console.WriteLine ("Hello World");
  
switch(exp)
{
  case 1: Console.WriteLine((a+b));
    break;

  case 2: Console.WriteLine((a-b));
    break;

  case 3: Console.WriteLine((a*b));
    break;

  case 4: Console.WriteLine((a/b));
    break;
    
  case 5: Console.WriteLine((a%b));
    break;

  default: Console.WriteLine("some other choice");
break;



//come out of the switch

  }
}
