using System;

class MainClass {
  public static void Main (string[] args) {
    unchecked{

    short Signed = short.MaxValue;
    ushort Unsigned = ushort.MaxValue ;

    Console.WriteLine($"{AsBin(Signed)}");
    Console.WriteLine($"{AsBin(Unsigned)}");
        
    }    
  }
    
    public static string AsBin(ushort x)
    {
        char[] buff = new char[16];
 
        for (int i = 15; i >= 0 ; i--)
        {
            int mask = 1 << i;
            buff[15 - i] = (x & mask) != 0 ? '1' : '0';
        }
 
        return new string(buff);
    }
    
    


    public static string AsBin(short x)
    {
        char[] buff = new char[16];
 
        for (int i = 15; i >= 0 ; i--)
        {
            int mask = 1 << i;
            buff[15 - i] = (x & mask) != 0 ? '1' : '0';
        }
 
        return new string(buff);
    }
}
