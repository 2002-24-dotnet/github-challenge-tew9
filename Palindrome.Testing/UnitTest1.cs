using System.Reflection;
using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Theory inner_data = "Ollo"]
        [Theory inner_data2 = "Civics"]

        public void Test1(string s)
        {
          var P = new Palindrome();

          //var inp = "OLLO"; //Fact
          var res = p.CheckPal(s);
          
          Assert.True(r);
        }
    }
}
