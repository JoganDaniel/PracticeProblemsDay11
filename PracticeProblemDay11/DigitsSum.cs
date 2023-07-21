using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class DigitsSum
    {
        public void SumOfDigits()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int digit, sum = 0;
            while(n>0)
            {
                digit = n % 10;
                sum += digit;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits : "+sum);
        }
    }
}
