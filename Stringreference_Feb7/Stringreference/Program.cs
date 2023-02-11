using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringreference
{
    class Program 
    {
        static void Main(string[] args)
        {
            object firstNum = 1;
            object secondNum = 2;
            object thirdNum = 2;
            Console.WriteLine(object.Equals(secondNum,thirdNum));
            Console.WriteLine(object.ReferenceEquals(secondNum,thirdNum));

            string str1 = "sunil";
            string str2 = "yaswanth";
            string str3 = "sunil";
            Console.WriteLine(string.Equals(str1,str3)); 
            Console.WriteLine(string.ReferenceEquals(str1,str3)); 
        }
    }
}
