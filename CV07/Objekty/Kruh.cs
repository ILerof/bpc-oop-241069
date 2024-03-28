namespace CV07
{
    public class Kruh : Objekt2D
    {
        private int r;

        public Kruh(int r)
        {
            this.r = r;
        }

        public override double Plocha()
        {
            return Math.PI * r * 2;
        }
        public override String ToString()
        {
            return String.Format("plocha kruha: " + Math.Round(Plocha(), 2));
        }
    }
}