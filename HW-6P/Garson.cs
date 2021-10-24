using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6P
{
    public static class Garson
    {
        public static double GetNumberFromUser(double min, double max)
        {
            bool isResultValid = false;
            double result = 0;
            while (!isResultValid)
            {
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min & result <= max)
                    {
                        isResultValid = true;
                    }
                    else if (result <= 0 || result < min || result > max)
                    {
                        Console.WriteLine($"You are just kidding me! Please enter the number between {min} and {max}");
                    }

                }
                else
                {
                    Console.WriteLine("ha-ha, it's very funny, now enter valid number");
                }
            }
            return result;
        }
        public static int GetNumberFromUser(int min, int max)
        {
            bool isResultValid = false;
            int result = 0;
            while (!isResultValid)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min & result <= max)
                    {
                        isResultValid = true;
                    }
                    else if (result <= 0 || result < min || result > max)
                    {
                        Console.WriteLine($"You are just kidding me! Please enter the number between {min} and {max}");
                    }

                }
                else
                {
                    Console.WriteLine("ha-ha, it's very funny, now enter valid number");
                }
            }
            return result;
        }
        public static int Randomaiser(int min, int max)
        {
            var r = new Random();
            int result = r.Next(min, max+1);
            return result;
        }
    }
}
