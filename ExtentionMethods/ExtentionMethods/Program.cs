using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "The quick brown fox jumped over the lazy dog";

            int wvowels = myString.CountVowels();
            Console.WriteLine(wvowels);

            int number = 55.DivideByFive();
            Console.WriteLine(number);

            double newNumber = (1001.05).TimesByPointFive();
            Console.WriteLine(newNumber);

            char aletter = 'a';
            Console.WriteLine(aletter.SCheck());

            bool check = true;
            Console.WriteLine(check.returnAge());

            float anotherNumber = 25.5F;
            Console.WriteLine(anotherNumber.divide());

            Console.ReadLine();
        }
    }
}
