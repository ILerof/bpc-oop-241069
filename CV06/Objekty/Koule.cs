class Koule : Objekt3D
{
    private double polomer;

    public Koule(double p)
    {
        polomer = p;
    }

    public override double SpoctiPovrch()
    {
        return 4 * Math.PI * polomer * polomer;
    }

    public override double SpoctiObjem()
    {
        return (4 * Math.PI * polomer * polomer * polomer) / 3;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Koule (r = {polomer}; v = {Math.Round(SpoctiObjem(),2)}; s = {Math.Round(SpoctiPovrch(),2)})");
    }
}