class Elipsa : Objekt2D
{
    private double A;
    private double B;

    public Elipsa(double a, double b)
    {
        A = a;
        B = b;
    }

    public override double SpoctiPlochu()
    {
        return A * B * Math.PI;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Elipsa (a = {A}; b = {B}; s = {Math.Round(SpoctiPlochu(),2)})");
    }
}