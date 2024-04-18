class Program
{
    static void Main(string[] args)
    {
        using (var context = new VyukaContext())
        {
            DbInitializer.Initialize(context);

            context.VypisPredmetySeStudenty();

            var studentiPredmetu = context.StudentiPredmetu(1);
            Console.WriteLine("\nStudenti predmetu Matematika:");
            foreach (var student in studentiPredmetu)
            {
                Console.WriteLine(student.Name);
            }

            var predmetyStudenta = context.PredmetyStudenta(1);
            Console.WriteLine("\nPredmety studenta Jan Novak:");
            foreach (var predmet in predmetyStudenta)
            {
                Console.WriteLine(predmet.Nazev);
            }
            context.VypisPrumerneZnamky();
        }
        
    }
}
