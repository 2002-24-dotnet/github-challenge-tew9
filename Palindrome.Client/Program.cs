using System;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          System.Console.WriteLine("Please enter a string\n");
          string input = Console.ReadLine();

          Palindrome p = new Palindrome();
          if(p.CheckPal(input))
          {
            System.Console.WriteLine("The Word {0} is palindrome", input);
          }
          else {
            System.Console.WriteLine("The Word {0} is not a palindrome", input);
          }

        }
    }
}
