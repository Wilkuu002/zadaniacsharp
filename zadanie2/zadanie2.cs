using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    public class zadanie2
    {

        private static void Rozwiazanie()
        { 
        for (int i = 1; i < 100; i++) 
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                if (i % 3 == 0 && i % 15 != 0)
                {
                    Console.WriteLine("Bis ");
                }
                if (i % 5 == 0 && i % 15 != 0)
                {
                    Console.WriteLine("Fis ");
                }
                if (i % 15 == 0)
                { 
                Console.WriteLine("BisFis ");
                }

            }
        }
        private static void Rozwiazanie2()
        {
            Enumerable.Range(1, 100).Select(x=>
            { 
                var str = "";
                if (x % 3 == 0)
                    str += "fis";
                if (x % 5 == 0)
                    str += "bis";
                if(str =="")
                    str=x.ToString();
                return str;
            }).ToList().ForEach(Console.WriteLine);


        }
        static void Main(string[] args)
        {
            //Rozwiazanie();
            
            Rozwiazanie2();
            Console.ReadLine();
        }
    }
}
