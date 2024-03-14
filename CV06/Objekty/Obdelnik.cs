class Obdelnik : Objekt2D
{
    private double stranaA;
    private double stranaB;

    public Obdelnik(double a, double b)
    {
        stranaA = a;
        stranaB = b;
    }

    public override double SpoctiPlochu()
    {
        return stranaA * stranaB;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Obdelnik (a = {stranaA}; b = {stranaB}; s = {Math.Round(SpoctiPlochu(),2)})");
    }
}