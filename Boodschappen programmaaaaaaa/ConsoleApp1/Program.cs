using System;

namespace Boodschappen
{
    class Program
    {
        const float btwPercentage = 0.21f;

        static void Main(string[] args)
        {
            const string product = "Doom Eternal";
            int aantal;
            const float prijsExclBtw = 20.0f;

            Console.WriteLine("Een disc " + product + " kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aantal + " discs " + product + " kosten in totaal " + btw(aantal, prijsExclBtw, btwPercentage));
            Console.Read();
        }
        static float btw(int aantal, float prijsExclBtw, float btwPercentage)
        {
            return aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage;
        }
    }
}
