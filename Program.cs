using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
  public static string WordsToNumbers(int number)
  {
    Dictionary <int, string> ones = new Dictionary<int, string>() {{0," "},{1,"one"},{2, "two"},{3,"three"},{4,"four"},{5,"five"},{6,"six"},{7,"seven"},{8,"eight"},{9,"nine"}, {10,"ten"}};

    Dictionary <int, string> teens = new Dictionary<int, string>(){{10,"teen"}};

    Dictionary <int, string> tens = new Dictionary<int, string>(){  {20,"twenty"},{30,"thirty"},{40,"forty"},{50,"fifty"},{60,"sixty"},{70,"seventy"},{80,"eighty"},{90,"ninety"}};

    if(number == 10)
    {
      return ones[10];
    }
    else if(10 < number && number < 20)
    {
      if(number == 18)
      {
        return "eighteen";
      }
      else
      {
        int onesOutput = number % 10;
        int tensOutput = number - onesOutput;
        return ones[onesOutput] + teens[tensOutput];
      }
    }
    else
    {
      int onesOutput = number % 10;
      int tensOutput = number - onesOutput;
      return tens[tensOutput] + ones[onesOutput];
    }



  }
  public static void Main()
  {
    Console.WriteLine(WordsToNumbers(88));

  }
}
