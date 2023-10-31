using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars13
{
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var liczby = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (liczby.ContainsKey(number))
                {
                    liczby[number]++;
                }
                else
                {
                    liczby[number] = 1;
                }
            }

            foreach (var kvp in liczby)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }
            return 0;
        }
    }

}
