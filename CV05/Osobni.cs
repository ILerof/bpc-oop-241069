class Osobni : Auto
{
    private int maxOsob;
    private int prepravovaneOsoby;

    public Osobni(int pocetOsob, double stavNadrze, TypPaliva mojePalivo) : base(stavNadrze, mojePalivo)
    {
        maxOsob = 5;
        velikostNadrze = 70;

        if (pocetOsob <= maxOsob && stavNadrze <= velikostNadrze)
        {
            prepravovaneOsoby = pocetOsob;
            palivo = mojePalivo;
        }
        else
        {
            throw new Exception("Presahnuta velkost nakladu nebo stav nadrze!");
        }
    }

    public override string ToString()
    {
        return String.Format($"Prepravovano osob:{prepravovaneOsoby}, Stav nadrze:{stavNadrze}, Typ paliva:{palivo}");
    }

}