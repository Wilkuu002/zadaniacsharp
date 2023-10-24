using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars5
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            Dictionary<char, int> czestoscZnakow = new Dictionary<char, int>();
            StringBuilder wynik = new StringBuilder();


            foreach (char znak in word)
            { 
            char malyZnak = char.ToLower(znak);
                if (czestoscZnakow.ContainsKey(malyZnak))
                {
                    czestoscZnakow[malyZnak]++;
                }
                else
                {
                    czestoscZnakow[malyZnak] = 1;
                }
            }
            foreach (char znak in word)
            {
                char malyZnak = char.ToLower(znak);
                if (czestoscZnakow[malyZnak] > 1)
                {
                    wynik.Append(')');
                }
                else { wynik.Append('('); }
            }
            

            return wynik.ToString();
        }
    }
}
