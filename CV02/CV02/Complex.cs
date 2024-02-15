
    public class Complex
    {
        public double Realna;
        public double Imaginarni;

        public Complex(double real, double imag)
        {
            this.Realna = real;
            this.Imaginarni = imag;
        }


        public static Complex operator +(Complex left, Complex right)
        {

            left.Realna += right.Realna;
            left.Imaginarni += right.Imaginarni;

            return left;
        }
        public static Complex operator -(Complex left, Complex right)
        {

            left.Realna -= right.Realna;
            left.Imaginarni -= right.Imaginarni;

            return left;
        }
        public static Complex operator *(Complex left, Complex right)
        {
            //(ac - bd) + (ad + bc)i
            var real = (left.Realna * right.Realna - left.Imaginarni * right.Imaginarni);
            var imag = (left.Realna * right.Imaginarni + left.Imaginarni * right.Realna);

            return new Complex(real, imag);
        }
        public static Complex operator /(Complex left, Complex right)
        {
            //((ac + bd) / (c2 + d2)) + ((bc - ad) / (c2 + d2)i
            var real = ((left.Realna * right.Realna + left.Imaginarni * right.Imaginarni) / (right.Realna * right.Realna + right.Imaginarni * right.Imaginarni));
            var imag = (left.Imaginarni * right.Realna + left.Realna * right.Imaginarni) / (right.Realna * right.Realna + right.Imaginarni * right.Imaginarni);

            return new Complex(real, imag);
        }
        public static Complex operator -(Complex num)
        {
            return new Complex(-num.Realna, -num.Imaginarni);
        }

        public static bool operator ==(Complex left, Complex right)
        {
            if (left.Realna == right.Realna && left.Imaginarni == right.Imaginarni) return true;
            return false;
        }
        public static bool operator !=(Complex left, Complex right)
        {

            if (left.Realna != right.Realna || left.Imaginarni != right.Imaginarni) return true;
            return false;
        }

        public override String ToString()
        {
            if (Imaginarni < 0) return $"{Realna}{Imaginarni}i";
            return $"{Realna}+{Imaginarni}i";
        }


        public double[] ToModArg()
        {
            var modul = Math.Sqrt(Realna * Realna + Imaginarni * Imaginarni);
            var argument = Math.Atan2(Imaginarni, Realna);

           return [modul, argument];
        
        }
    }