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
        }
    }
}