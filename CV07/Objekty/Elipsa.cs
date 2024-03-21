namespace CV07
{
    public class Elipsa : Objekt2D
    {
        private int x;
        private int y;

        public Elipsa(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override double Plocha()
        {
            return Math.PI * x * y;
        }

        public override String ToString()
        {
            return String.Format("plocha elipsa: " + Math.Round(Plocha(), 2));
        }
    }
}