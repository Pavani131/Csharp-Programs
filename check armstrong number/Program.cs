using System;

namespace check_armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, originalNum, remainder, result = 0, n = 0;
            Console.WriteLine("enter an integer:");
            num = int.Parse(Console.ReadLine());
            originalNum = num;
            while(originalNum != 0)
            {
                originalNum /= 10;
                ++n;
            }
            originalNum = num;
            while(originalNum !=0)
            {
                remainder = originalNum % 10;
                result += (int)Math.Pow(remainder, n);
                originalNum /= 10;

            }
            if (result == num)
                Console.WriteLine(num + "is an Armstrong Number.");
            else
                Console.WriteLine(num + "is not an Armstrong Number.");

        }
    }
}
