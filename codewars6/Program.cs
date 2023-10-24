using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars6
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
                    
            string[] liczbyJakoTeksty = numbers.Split(' ');

            
            int[] TablicaNumerow = new int[liczbyJakoTeksty.Length];
            int najwieksza = int.MinValue;
            int najmniejsza = int.MaxValue;

            for (int i = 0; i < liczbyJakoTeksty.Length; i++)
            {
                TablicaNumerow[i] = int.Parse(liczbyJakoTeksty[i]);
                if (TablicaNumerow[i]>najwieksza) najwieksza = TablicaNumerow[i];
                if (TablicaNumerow[i] < najmniejsza) najmniejsza = TablicaNumerow[i];
            }
            string wynik = $"{najwieksza} {najmniejsza}";

            return wynik;
        }
    }
}
