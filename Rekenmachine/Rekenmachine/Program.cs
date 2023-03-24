using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {

            float antwoord = 0.0f;

            Console.WriteLine("Welkom bij deze rekenmachine wat is het 1e getal? ");
            var InputGetal1 = Console.ReadLine();

            float Getal1 = 0.0f;
            while (float.TryParse(InputGetal1, out Getal1)== false)
            {
                Console.WriteLine("GETAL!!!");
                InputGetal1 = Console.ReadLine();
            }
            Console.WriteLine("En de 2e? ");
            var InputGetal2 = Console.ReadLine();

            float Getal2 = 0.0f;

            while (float.TryParse(InputGetal2, out Getal2)==false)
            {
                Console.WriteLine("GETAL!!!");
                InputGetal2 = Console.ReadLine();
            }


            Console.WriteLine("Wil je + - * of / ");
            string watDoen = Console.ReadLine();
            if (watDoen == "+"){
                antwoord = Getal1 + Getal2;
                Console.Write(antwoord);
                Console.ReadLine();
            }
            if (watDoen == "-"){
                antwoord = Getal1 - Getal2;
                Console.Write(antwoord);
                Console.ReadLine();
            }
            if (watDoen == "*")
            {
                antwoord = Getal1 * Getal2;
                Console.Write(antwoord);
                Console.ReadLine();
            }
            if (watDoen == "/")
            {
                if (Getal2 > 0){
                    antwoord = Getal1 / Getal2;
                    Console.WriteLine(antwoord);
                    Console.ReadLine();
                }
                else{
                    Console.WriteLine("Are you serious right now delen door 0!!!");
                    Console.ReadLine();
                }
            }        
        }
    }
}
