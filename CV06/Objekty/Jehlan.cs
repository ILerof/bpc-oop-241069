class Jehlan : Objekt3D
{
    private double stranaA;
    private double stranaB;
    private double vyska;

    public Jehlan(double a, double b, double h)
    {
        stranaA = a;
        stranaB = b;
        vyska = h;
    }

    public override double SpoctiPovrch()
    {
        return stranaA * vyska * 2;
    }

    public override double SpoctiObjem()
    {
        return (stranaA * stranaA * vyska) / 3;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Jehlan (a = {stranaA}; b = {stranaB}; h = {vyska}; s = {Math.Round(SpoctiPovrch(),2)}; v = {Math.Round(SpoctiObjem(),2)})");
    }
}