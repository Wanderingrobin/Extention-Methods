using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class Divide
    {
        public static int DivideByFive(this int num)
        {
            return num / 5;
        }
    }

   public static class CountWordClass
    {
     public static int CountVowels(this string oGString)
        {
            int count = 0;

            foreach (char c in oGString)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }

            return count;
        }
    }

    public static class PointFive
    {
        public static double TimesByPointFive(this double num)
        {
            return num * 0.5;
        }
    }

    public static class CheckForS
    {
        public static string SCheck(this char nextChar)
        {
            if (nextChar == 's')
            {
                return "You found s";
            }
             else
            {
                return "Keep looking";
            }   
        }
    }

    public static class BoolExt
    {
        public static int returnAge(this bool var)
        {
            if (var == true)
            {
                return 29;
            }
            else
            {
                return 30;
            }
        }
    }

    public static class FloatExt
    {
        public static double divide(this float num)
        {
            Console.WriteLine("Enter the num to be divided");
            string a = Console.ReadLine();

            return num / (Convert.ToDouble(a));
        }
    }
        
}
