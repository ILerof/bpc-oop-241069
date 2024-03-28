class Program
{
    static void Main(string[] args)
    {
        GrObjekt[] pole = new GrObjekt[] {
                    new Elipsa(3, 5),
                    new Jehlan(5, 10, 3),
                    new Koule(5),
                    new Kruh(2),
                    new Kvadr(2, 4, 8),
                    new Obdelnik(4, 7),
                    new Trojuhelnik(3, 4, 5),
                    new Valec(3, 12)
            };

        double plocha = 0;
        double povrch = 0;
        double objem = 0;

        foreach (var item in pole)
        {
            item.Kresli();
            if (item is Objekt2D)
            {

                plocha += ((Objekt2D)item).SpoctiPlochu();
            }
            else
            {
                povrch += ((Objekt3D)item).SpoctiPovrch();
                objem += ((Objekt3D)item).SpoctiObjem();
            }
        }

        Console.WriteLine($"\nCelkova plocha je: {Math.Round(plocha,2)} \nCelkovy povrch je: {Math.Round(povrch,2)} \nCelkovy objem je: {Math.Round(objem,2)}");
        Console.ReadKey();
    }
}