public class Hodnoceni
{
    public int HodnoceniId { get; set; }
    public int StudentId { get; set; } 
    public int PredmetId { get; set; } 
    public int Znamka { get; set; }
    public Student Student { get; set; } 
    public Predmet Predmet { get; set; } 
}
