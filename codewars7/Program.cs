using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars7
{
    public class Accumul
    {
        
        public static String Accum(string s)
        {
            StringBuilder wynik = new StringBuilder();
            char[] tablicacharow = s.ToCharArray();
            for (int i = 0; i < tablicacharow.Length; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    if (k == 0)
                    {
                        wynik.Append(char.ToUpper(tablicacharow[i]));
                    }
                    else
                    {
                        wynik.Append(char.ToLower(tablicacharow[i]));
                    }
                }
                if (i < tablicacharow.Length-1) 
                {
                    wynik.Append('-');
                }
                
                    
            }
            return wynik.ToString();
        }
    }
}
