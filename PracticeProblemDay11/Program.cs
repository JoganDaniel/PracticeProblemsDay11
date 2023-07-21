using System;
namespace PracticeProblemDay11
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Duplicates in array\n2.Unique Elements in array\n3.Frequency of Elements\n4.Maximum and minimum\n5.Pattern 1" +
                    "\n6.Pattern 2\n7.Reverse Each word\n8.Sum of digits\n9.Capitalize words\n10.Sum of 2 minimum number\n11.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        DuplicateElements dup = new DuplicateElements();
                        dup.DuplicateInArray();
                        break;
                    case 2:
                        UniqueElements unique = new UniqueElements();   
                        unique.UniqueInArray();
                        break;
                    case 3:
                        Frequency frequency = new Frequency();
                        frequency.FrequencyOfElements();
                        break;
                    case 4:
                        MaxAndMin max = new MaxAndMin();
                        max.MaximumMinimum();
                        break;
                    case 5:
                        Pattern1 pattern = new Pattern1();
                        pattern.PrintPattern();
                        break;
                    case 6:
                        Pattern2 pattern2 = new Pattern2();
                        pattern2.PrintPattern();
                        break;
                    case 7:
                        ReverseWords words = new ReverseWords();
                        words.ReverseEachWords();
                        break;
                    case 8:
                        DigitsSum sum = new DigitsSum();
                        sum.SumOfDigits();
                        break;
                    case 9:
                        Capitalize capitalize = new Capitalize();
                        capitalize.CapitalizeEachWord();
                        break;
                    case 10:
                        SumOfMin sumOfMin = new SumOfMin();
                        sumOfMin.MinSum();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}