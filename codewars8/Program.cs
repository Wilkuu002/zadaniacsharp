using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars8
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder NumerTelefonu = new StringBuilder();

            NumerTelefonu.Append("(");

            for (int i = 0; i < numbers.Length; i++)
            {
                NumerTelefonu.Append(numbers[i]);

                if (i == 2)
                {
                    NumerTelefonu.Append(") ");
                }
                else if (i == 5)
                {
                    NumerTelefonu.Append("-");
                }
            }

            return NumerTelefonu.ToString();
        }
    }
}
