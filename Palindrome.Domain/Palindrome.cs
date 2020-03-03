
using System;
using System.Collections.Generic;
namespace Palindrome.Domain
{
    public class Palindrome
    {
      private string test = "ollo";
      private List<string> pal =  new List<string>();
      
      public List<String> GetPalindrome(string input)
      {
        int i = 0;
        while(i < test.length)
        {
          for(j = test.length - 1; j >= i; j--)
          {
            if(test[i] == test[j])
            {
              pal.Add(test[i]);
              break;
            }
          }

          i++;
        }

       return pal;
       
      }
    }
}