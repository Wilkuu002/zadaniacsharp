using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Program
    {
        public static bool Rozwiazanie(string input)
        { 
            Stack<char> nawiasy = new Stack<char>();
            Dictionary<char,char> nawiasyPary = new Dictionary<char,char>()
            {
                { '{','}' },
                { '(',')' },
                { '<','>' },
                { '[',']' },
             };
            try 
            {
                foreach (var znak in input)
                {
                    if (nawiasyPary.Keys.Contains(znak))
                        nawiasy.Push(znak);
                    else if (nawiasyPary.Values.Contains(znak))
                    {
                        if (znak == nawiasyPary[nawiasy.First()])
                        {
                            nawiasy.Pop();

                        }
                        else
                        { return false; }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch(Exception)
            { 
            return false;
            }
            return nawiasy.Count() == 0 ? true : false;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciag nawiasów");
            string input = Console.ReadLine();
            Console.WriteLine(Rozwiazanie(input));
            Console.ReadLine();
        }
    }
}
