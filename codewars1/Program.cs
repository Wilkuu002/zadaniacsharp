using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codewars1;

namespace codewars1
{
    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            char[] dnaPodzielonaTablica = dna.ToCharArray();
            char[] tablicaDnaZamieniona = new char[dnaPodzielonaTablica.Length];
            for (int i = 0; i < dnaPodzielonaTablica.Length;i++)
            {
                if (dnaPodzielonaTablica[i] == 'A')
                {
                    tablicaDnaZamieniona[i] = 'T';
                }
                else if (dnaPodzielonaTablica[i] == 'T')
                {
                    tablicaDnaZamieniona[i] = 'A';
                }
                else if (dnaPodzielonaTablica[i] == 'C')
                {
                    tablicaDnaZamieniona[i] = 'G';
                }
                else if (dnaPodzielonaTablica[i] == 'G')
                {
                    tablicaDnaZamieniona[i] = 'C';
                }
                else
                {
                    tablicaDnaZamieniona[i] = dnaPodzielonaTablica[i];
                }
            }
            return new string(tablicaDnaZamieniona);
        }
    }
}





