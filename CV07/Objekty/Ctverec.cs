namespace CV07
{
    public class Ctverec : Objekt2D
    {
        private int x;
        public Ctverec(int x)
        {
            this.x = x;
        }

        public override double Plocha()
        {
            return x * x;
        }
        public override String ToString()
        {
            return String.Format("plocha ctverce: " + Math.Round(Plocha(), 2));
        }
    }
}
