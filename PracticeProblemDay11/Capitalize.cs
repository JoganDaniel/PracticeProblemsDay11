using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class Capitalize
    {
        public void CapitalizeEachWord()
        {
            string ans = "";
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new[] { ' ' });
            foreach (string word in words)
            {
                for (int i=0;i<word.Length;i++)
                {
                    if (i == 0)
                    {
                        char c = Char.ToUpper(word[i]);
                        ans += c;
                    }
                    else
                    {
                        ans += word[i];
                    }
                }
                ans += " ";
            }
            Console.WriteLine(ans);
        }
    }
}
