using System;

namespace Check_even_or_odd_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 6, 3, 9, 5, 2, 1, 7, 4, 10 };
            
            foreach(int num in arr)
            {
                if(num%2 ==0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
        }
    }
}
