using Microsoft.EntityFrameworkCore;

public class VyukaContext : DbContext
{
    public DbSet<Student> Studenti { get; set; }
    public DbSet<Predmet> Predmety { get; set; }
    public DbSet<Hodnoceni> Hodnoceni { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ivan\\Desktop\\Studium VUT\\3 course\\Summer semestr\\BPC-OOP\\CV011\\Database1.mdf\";Integrated Security=True");
    }


    public void VypisPredmetySeStudenty()
    {
        var predmetySeStudenty = Predmety
            .Include(p => p.Hodnoceni)
            .Select(p => new
            {
                Predmet = p.Nazev,
                PocetStudentu = p.Hodnoceni.Select(h => h.StudentId).Distinct().Count()
            })
            .OrderByDescending(x => x.PocetStudentu)
            .ToList();

        Console.WriteLine("Predmety s poctem zapsanych studentu:");
        foreach (var item in predmetySeStudenty)
        {
            Console.WriteLine($"{item.Predmet}: {item.PocetStudentu} studentu");
        }
    }

    public IEnumerable<Student> StudentiPredmetu(int predmetId)
    {
        return Hodnoceni
            .Where(h => h.PredmetId == predmetId)
            .Select(h => h.Student)
            .Distinct()
            .ToList();
    }

    public IEnumerable<Predmet> PredmetyStudenta(int studentId)
    {
        return Hodnoceni
            .Where(h => h.StudentId == studentId)
            .Select(h => h.Predmet)
            .Distinct()
            .ToList();
    }

    public void VypisPrumerneZnamky()
    {
        var prumerneZnamky = Hodnoceni
            .GroupBy(h => h.Predmet)
            .Select(g => new
            {
                Predmet = g.Key.Nazev,
                Prumer = g.Average(h => h.Znamka)
            })
            .ToList();

        Console.WriteLine("\nPrumerne znamky:");
        foreach (var item in prumerneZnamky)
        {
            Console.WriteLine($"{item.Predmet}: {item.Prumer}");
        }
    }


}
public static class DbInitializer
{
    public static void Initialize(VyukaContext context)
    {
        context.Database.EnsureCreated();

        if (context.Studenti.Any())
            return;

        var studenti = new Student[]
        {
            new Student { Name = "Jan Novak" },
            new Student { Name = "Marie Dvorakova" }
        };
        foreach (var s in studenti)
        {
            context.Studenti.Add(s);
        }
        context.SaveChanges();

        var predmety = new Predmet[]
        {
            new Predmet { Nazev = "Matematika" },
            new Predmet { Nazev = "Fyzika" }
        };
        foreach (var p in predmety)
        {
            context.Predmety.Add(p);
        }
        context.SaveChanges();

        var hodnoceni = new Hodnoceni[]
        {
            new Hodnoceni { StudentId = 1, PredmetId = 1, Znamka = 1 },
            new Hodnoceni { StudentId = 1, PredmetId = 2, Znamka = 2 },
            new Hodnoceni { StudentId = 2, PredmetId = 1, Znamka = 3 },
            new Hodnoceni { StudentId = 2, PredmetId = 2, Znamka = 1 }
        };
        foreach (var h in hodnoceni)
        {
            context.Hodnoceni.Add(h);
        }
        context.SaveChanges();
    }
}


