using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {

            int liczba = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    liczba = seq[i];
                }
            }
            return liczba;
        }

    }
}


