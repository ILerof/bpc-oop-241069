class Kruh : Objekt2D
{
    private double polomer;

    public Kruh(double p)
    {
        polomer = p;
    }

    public override double SpoctiPlochu()
    {
        return Math.PI * polomer * polomer;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Kruh (r = {polomer}; s = {Math.Round(SpoctiPlochu(),2)})");
    }
}