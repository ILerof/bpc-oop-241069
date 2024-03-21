namespace CV07
{
    public abstract class Objekt2D : I2D, IComparable
    {
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is Objekt2D)
            {
                return this.Plocha().CompareTo(((Objekt2D)obj).Plocha());
            }

            throw new ArgumentException("Pro porovnani je vyzadovan Objekt2D.", "obj");
        }
        public abstract double Plocha();
    }
}