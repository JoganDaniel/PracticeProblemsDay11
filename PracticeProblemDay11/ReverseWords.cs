﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay11
{
    public class ReverseWords
    {
        public void ReverseEachWords()
        {
            string ans="";
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new[] { ' ' });
            foreach (string word in words)
            {
                for(int i=word.Length-1; i>=0; i--)
                {
                    ans += word[i];
                }
                ans += " ";
            }
            Console.WriteLine(ans);
        }
    }
}
