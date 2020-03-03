
using System;
using System.Collections.Generic;
namespace Palindrome.Domain
{
    public class Palindrome
    {
      private string test = "ollo";
      private List<string> pal =  new List<string>();
      
      public List<String> CheckPal(string input)
      {
       
        char[] ar_string = s.ToCharArray();
        string new_s = Array.Reverse(ar_string).ToString();

        return new_s == ar_string;
      }
    }
}