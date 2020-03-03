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
          List<String> pal = p.GetPalindrome(input);

          CheckPal();
        }

        private static CheckPal()
        {
          if(pal.length == input.length)
          {
            System.Console.WriteLine("The Word {0} is palindrome of {0}", input, pal);
          }else{
            System.Console.WriteLine("The Word {0} is not a palindrome of {0}", input, pal);
          }
        }
        
    }
}
