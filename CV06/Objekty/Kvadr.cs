class Kvadr : Objekt3D
{
    private double stranaA;
    private double stranaB;
    private double stranaC;

    public Kvadr(double a, double b, double c)
    {
        stranaA = a;
        stranaB = b;
        stranaC = c;
    }

    public override double SpoctiPovrch()
    {
        return 2 * (stranaA * stranaB + stranaB * stranaC + stranaA * stranaC); // (S1 + S2 + S3)
    }

    public override double SpoctiObjem()
    {
        return stranaA * stranaB * stranaC;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Kvadr (a = {stranaA}; b = {stranaB}; c = {stranaC}; s = {Math.Round(SpoctiPovrch(),2)}; v = {Math.Round(SpoctiObjem(),2)})");
    }
}