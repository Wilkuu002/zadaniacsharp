using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars10
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            StringBuilder zdanie = new StringBuilder();
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++) 
            {
                if (5 <= words[i].Length)
                {
                    string odwroconyWyraz = new string(words[i].Reverse().ToArray());
                    zdanie.Append(odwroconyWyraz);
                }
                else
                {
                    zdanie.Append(words[i]);
                }
                zdanie.Append(" ");
             }
 
            return zdanie.ToString().Trim();
        }
    }
}
