using System;

namespace Reverse_the_String_with_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "hello world";
            string reversed = ReverseString(original);
            Console.WriteLine(reversed);

        }
        public static string ReverseString(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
            else
                return str;
        }

    }
    
}
