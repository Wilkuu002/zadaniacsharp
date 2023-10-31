using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace codewars11
{
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            StringBuilder polubienia = new StringBuilder();
            switch (name.Length) 
            {
            case 0:
                    polubienia.Append("no one likes this");
                    break;
            case 1:
                    polubienia.Append(name[0]+ " likes this");
                    break;
            case 2:
                    polubienia.Append(name[0] + " and " + name[1] + " like this");
                    break;
            case 3:
                    polubienia.Append(name[0] + ", " + name[1]+ " and "+ name[2] + " like this");
                    break;
            case 4:

                    polubienia.Append($"{name[0]}, {name[1]} and {name.Length-2}" + " others like this");
                    break;
            }
            return polubienia.ToString();
        }
    }
}
