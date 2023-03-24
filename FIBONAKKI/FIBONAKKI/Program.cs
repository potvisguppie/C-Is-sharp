using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONAKKI
{
    class Program
    {
        static void Main(string[] args)
        {
            int oudGetal = 1;
            int nieuwGetal = 1;

            for (int teller = 1; teller <= 20; teller++)
            {
                int nieuwsteGetal = oudGetal + nieuwGetal;
                Console.WriteLine(nieuwsteGetal);
                nieuwGetal = oudGetal;
                oudGetal = nieuwsteGetal; 
            }
            Console.ReadLine();
        }
    }
}
