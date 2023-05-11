using System;

namespace no_of_digits_in_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123456;
            int count = 0;
            while(num != 0)
            {
                num /= 10;
                count++;
            }
            Console.WriteLine("no of digits:" + count);
        }
    }
}
