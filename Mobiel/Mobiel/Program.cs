using Mobiel;
using System;

namespace Mobiel
{
    public class Telefoon
    {
        public string type;
        public string model;
        public string os;
        public string ceo;
        public Telefoon(string nType, string nModel, string nOS, string nCEO){
            type = nType;
            model = nModel;
            os = nOS;
            ceo = nCEO;
        }

    }
}

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            Telefoon telefoon1 = new Telefoon("iPhone", "iPhone XS", "Apple IOS", "Steve Jobs");
            Telefoon telefoon2 = new Telefoon("Samsung", "Galaxy S7", "Android", "Kinam Kin");
            Telefoon telefoon3 = new Telefoon("Google Pixel", "Pixel 3", "Chrome OS", "Sundar Pichai");

            Console.WriteLine(telefoon1.type);
            Console.WriteLine(telefoon1.model);
            Console.WriteLine(telefoon1.os);
            Console.WriteLine(telefoon1.ceo);

            Console.WriteLine();

            Console.WriteLine(telefoon2.type);
            Console.WriteLine(telefoon2.model);
            Console.WriteLine(telefoon2.os);
            Console.WriteLine(telefoon2.ceo);

            Console.WriteLine();

            Console.WriteLine(telefoon3.type);
            Console.WriteLine(telefoon3.model);
            Console.WriteLine(telefoon3.os);
            Console.WriteLine(telefoon3.ceo);

            Console.ReadLine();
        }
    }
}
