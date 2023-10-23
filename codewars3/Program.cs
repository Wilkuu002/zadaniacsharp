using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars3
{
    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            string obydwa = s1 + s2;
            string wynik = new string(obydwa.Distinct().OrderBy(c => c).ToArray());

            return wynik;
        }
        public static void Main()
        {
            string a = "asdfththhhuyktyjk";
            string b = "asdfththhbbbgjkuyiouyoqwrewgnhuyktyhhhiooopplqqaszxcjk";
            Console.WriteLine(Longest(a, b));
            Console.ReadKey();
        }
    }
}
