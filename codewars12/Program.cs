using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars12
{
    public class rozwiazanie
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            int poczatek = 0;
            int koniec = 0;
            int maksymalnaSuma = arr[0];
            int bierzacaSuma = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                bierzacaSuma += arr[i];

                if (bierzacaSuma > maksymalnaSuma)
                {
                    maksymalnaSuma = bierzacaSuma;
                    koniec = i;
                }
                if (bierzacaSuma <= 0)
                {
                    bierzacaSuma = 0;
                    poczatek = i + 1;
                }
            }
            return maksymalnaSuma;
        }
    }
}
