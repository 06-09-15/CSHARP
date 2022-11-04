using System;

class Program {
    public static void Main(string[] args) {
      int a = 800;
      Console.WriteLine("a = {0}", a);
      Console.WriteLine("a ^= 3 : {0}", a^=3);
      Console.WriteLine("a >>= 3 : {0}", a>>=3);
      Console.WriteLine("a <<= 3 : {0}", a<<=3);
      Console.WriteLine("a += 3 : {0}", a+=3);
      Console.WriteLine("a -= 3 : {0}", a-=3);
      Console.WriteLine("a *= 3 : {0}", a*=3);
      Console.WriteLine("a /= 3 : {0}", a/=3);
      Console.WriteLine("a %= 3 : {0}", a%=3);
      Console.WriteLine("a &= 3 : {0}", a&=3);
      Console.WriteLine("a |= 3 : {0}", a|=3);
      
    }
}
      
