using System.Xml;

namespace Inlämning_D15_Grundämnen
{
    internal class Program
    {
        public class Grundämne
        {
            public string namn = "";
            public int atomnummer = 0;
            public string typ = "";
            public double smältpunkt = 0;
            public double kokpunkt = 0;
            public void print()
            {
                Console.WriteLine($"Grundämne: {namn}\n typ: {typ}\n " +
                    $"smältpunkt: {smältpunkt}\n kokpunkt: {kokpunkt}\n");
            }
        }
        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne()
            {
                namn = "Syre",
                atomnummer = 8,
                typ = "ickemetall",
                smältpunkt = 54.36,
                kokpunkt = 90.188,
            };
            Grundämne järn = new Grundämne() 
            {
                namn = "Järn",
                atomnummer = 26,
                typ = "metall",
                smältpunkt = 1811,
                kokpunkt = 3134,
            };
            Grundämne guld = new Grundämne()
            {
                namn = "Guld",
                atomnummer = 79,
                typ = "metall",
                smältpunkt = 1337.33,
                kokpunkt = 3243,
            };
            /*syre.print();
            järn.print();
            guld.print();*/
            Grundämne[] grundämnen = new Grundämne[6];
            grundämnen[0] = syre;
            grundämnen[1] = järn;
            grundämnen[2] = guld;
            grundämnen[3] = new Grundämne()
            {
                namn = "Väte",
                atomnummer = 1,
                typ = "ickemetall",
                smältpunkt = 13.99,
                kokpunkt = 20.271,
            };
            grundämnen[4] = new Grundämne()
            {
                namn = "Brom",
                atomnummer = 35,
                typ = "ickemetall",
                smältpunkt = 265.8,
                kokpunkt = 332.0,
            };
            grundämnen[5] = new Grundämne()
            {
                namn = "Kvicksilver",
                atomnummer = 80,
                typ = "metall",
                smältpunkt = 234.3210,
                kokpunkt = 629.88,
            };
            foreach (Grundämne grundämne in grundämnen)  grundämne.print(); 
            Console.WriteLine("Metaller:");
            foreach(Grundämne grundämne in grundämnen)
            {
                if (grundämne.typ == "metall") Console.WriteLine($"  {grundämne.namn}"); 
            }
        }
    }
}