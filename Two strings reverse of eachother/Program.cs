using System;
using System.Linq;

namespace Two_strings_reverse_of_eachother
{
    class Program
    { 
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "olleh";
            if(str1.Reverse().SequenceEqual(str2))
            {
                Console.WriteLine("The strings are reverse of eachother.");

            }
            else
            {
                Console.WriteLine("The strings are not reverse of eachother.");
            }
        }
    }
}
