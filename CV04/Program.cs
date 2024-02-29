class Program
{
    static void Main(string[] args)
    {
        string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
        + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
        + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
        + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
        + "posledni veta!"
        ;

        StringStatistics stats = new StringStatistics(testovaciText);

        Console.WriteLine(testovaciText + "\n");
        Console.WriteLine("Pocet slov:" + stats.CountOfWords());
        Console.WriteLine("Pocet radku:" + stats.CountOfLines());
        Console.WriteLine("Pocet vet:" + stats.CountOfSentences());

        Console.Write("Nejdelsi slova:");
        Console.WriteLine(String.Join(", ", stats.LongestWords()));

        Console.Write("Nejkratsi slova: ");
        Console.WriteLine(String.Join(", ", stats.ShortestWords()));

        Console.Write("Nejcastejsi slova: ");
        Console.WriteLine(String.Join(", ", stats.OftenWords()));

        Console.Write("Slova podle abecedy: ");
        Console.WriteLine(String.Join(", ", stats.Alphabet()));
        Console.ReadKey();
    }
}