using LoremIpsumLibrary;
using System;

namespace ExampleApplication
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      string text = LoremIpsum.CreateAllText();
      Console.WriteLine(text);

      string bigText = LoremIpsum.CreateText(LipsumType.Words, 3);
      Console.WriteLine(bigText);

      string text1 = LoremIpsum.CreateText(LipsumType.Words, 50);
      Display(text1);
      string text2 = LoremIpsum.CreateText(LipsumType.Paragraphs, 3);
      Display(text2);
      string text3 = LoremIpsum.CreateText(LipsumType.Lists, 5);
      Display(text3);

      Console.WriteLine(text1);

      Display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
