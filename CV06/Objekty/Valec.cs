class Valec : Objekt3D
{
    private double polomer;
    private double vyska;

    public Valec(double polomer, double vyska)
    {
        this.polomer = polomer;
        this.vyska = vyska;
    }

    public override double SpoctiPovrch()
    {
        return Math.PI * polomer * 2 * (polomer + vyska); // l =  √(r^2 + h^2); S = PI*r^2 + PI * r * l
    }

    public override double SpoctiObjem()
    {
        return (Math.PI * polomer * polomer * vyska) / 3;
    }

    public override void Kresli()
    {
        Console.WriteLine($"Valec (r = {polomer}; h = {vyska}; s = {Math.Round(SpoctiPovrch(),2)}; v = {Math.Round(SpoctiObjem(),2)})");
    }
}