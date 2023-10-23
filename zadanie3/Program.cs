using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        private static bool CzyPalidrom(string zdanie)
        {
           // Console.WriteLine("Wprowadź zdanie");
            zdanie = zdanie.Replace(" ","").ToLower();
            return zdanie == new string(zdanie.ToCharArray().Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy jest Palidromem");
            if (CzyPalidrom("kayak "))
                Console.WriteLine("Tak");
            else Console.WriteLine("Nie");
            Console.ReadLine(); 
            
        }
    }
}
