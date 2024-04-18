public class Predmet
{
    public int PredmetId { get; set; }
    public string Nazev { get; set; }
    public ICollection<Hodnoceni> Hodnoceni { get; set; }
}