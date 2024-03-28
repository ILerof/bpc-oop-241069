using System.Linq;

namespace CV07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poleInt = [1, 5, 3, 7, 9];
            string[] poleString = ["11", "00", "01"];
            Kruh[] poleKruh = [new Kruh(6), new Kruh(3), new Kruh(1)];
            Obdelnik[] poleObdelnik = [new Obdelnik(5, 8), new Obdelnik(3, 6), new Obdelnik(3, 9)];
            Elipsa[] poleElipsa = [new Elipsa(3, 8), new Elipsa(7, 3), new Elipsa(2, 2)];
            Objekt2D[] poleObj = [new Kruh(2), new Ctverec(7), new Elipsa(5, 7)];

            //Kruh
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleKruh));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleKruh));

            Console.WriteLine("\n----------------------------------------");

            //Obdelnik
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleObdelnik));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleObdelnik));

            Console.WriteLine("\n----------------------------------------");

            //Elipsa
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleElipsa));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleElipsa));

            Console.WriteLine("\n----------------------------------------");

            //Objekt
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleObj));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleObj));

            Console.WriteLine("\n----------------------------------------");

            //String
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleString));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleString));

            Console.WriteLine("\n----------------------------------------");

            //Int
            Console.WriteLine("Nejvetsi " + Extremy.Nejvetsi(poleInt));
            Console.WriteLine("Nejmensi " + Extremy.Nejmensi(poleInt));

            Console.WriteLine("\n----------------------------------------");

            IEnumerable<int> filtered = 
                from Int in poleInt
                where Int >= 4 && Int <= 8
                select Int;

            Console.Write("LINQ filtrace: ");
            Console.WriteLine(String.Join(", ", filtered));

            Console.ReadKey();
        }
    }
}