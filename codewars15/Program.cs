using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace codewars15
{
    public class Kata
    {
        public static string Add(string a, string b)
        {
            BigInteger liczbaA = BigInteger.Parse(a);
            BigInteger liczbaB = BigInteger.Parse(b);

            return (liczbaB + liczbaA).ToString();
        }
    }
}
