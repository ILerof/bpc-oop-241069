using System.Buffers;
using System.Threading.Channels;
using System.Xml.Schema;

class Program
{
     static void Main(string[] args)
     {
         Osobni osob = new Osobni(2, 63, Auto.TypPaliva.Benzin);
         Nakladni naklad = new Nakladni(15, 70, Auto.TypPaliva.Nafta);

         osob.nastavRadio(true);
         osob.nastavPredvolbu(1, 117.2);
         osob.preladNaPredvolbu(1);
         osob.vypisRadio();
         Console.WriteLine(osob);




         naklad.nastavRadio(true);
        try
        {
            naklad.nastavPredvolbu(2, 222.2);
            naklad.preladNaPredvolbu(3);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        naklad.preladNaPredvolbu(2);
         naklad.vypisRadio();
         Console.WriteLine(naklad);
         Console.ReadKey();
     }
}
