namespace CV07
{
    public class Obdelnik : Objekt2D
    {
        private int x;
        private int y;

        public Obdelnik(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override double Plocha()
        {
            return x * y;
        }

        public override String ToString()
        {
            return String.Format("plocha obdelnika: " + Math.Round(Plocha(), 2));
        }
    }
}