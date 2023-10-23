using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    public static bool XO(string input)
    {
        char[] tablicaCharow= input.ToCharArray();
        int ileX = 0;
        int ileO = 0;
        for (int i = 0; i < tablicaCharow.Length; i++)
        {
            if (tablicaCharow[i] == 'x' || tablicaCharow[i] == 'X')
            { 
                ileX++;
            }
            if ((tablicaCharow[i] == 'o' || tablicaCharow[i] == 'O'))
            { 
            ileO++;
            }
        }
        if (ileX == ileO)
        { 
            return true; 
        }
        else { return false; }          
    }
}