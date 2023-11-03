using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars14
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            string[] tablica= numbers.Split(' ');
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            foreach (var jakotekst in tablica) 
            {
            int number = int.Parse(jakotekst);
            if (number > highest) {highest = number;}
            if (number < lowest) { lowest = number; }
            }
            return highest.ToString()+" "+lowest.ToString() ;
        }
    }
}
