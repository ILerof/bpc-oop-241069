class Nakladni : Auto
{
    private int maxNaklad;
    private int prepravovanyNaklad;

    public Nakladni(int velikostNakladu, double stavNadrze, TypPaliva palivo) : base(stavNadrze, palivo)
    {
        maxNaklad = 100;
        velikostNadrze = 120;

        if (velikostNakladu <= maxNaklad && stavNadrze <= velikostNadrze)
        {
            prepravovanyNaklad = velikostNakladu;
            this.palivo = palivo;
        }
        else
            throw new Exception("Presahnuta velkost nakladu nebo stav nadrze!");
    }

    public override string ToString()
    {
        return String.Format($"Prepravovany naklad:{prepravovanyNaklad}, Stav nadrze:{stavNadrze}, Typ paliva:{palivo}");
    }
}