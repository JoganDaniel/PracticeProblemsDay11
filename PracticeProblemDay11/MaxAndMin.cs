using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class MaxAndMin
    {
        public void MaximumMinimum()
        {
            int max, min;
            Console.WriteLine("Enter length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter the numbers in array");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max= arr[0];
            min = arr[0];
            for(int i = 0;i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max element : "+max);
            Console.WriteLine("Min element : "+min);
        }
    }
}
