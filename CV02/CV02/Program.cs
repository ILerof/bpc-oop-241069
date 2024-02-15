
    class Program
    {
    static void Main(string[] args)
    {
        TestComplex.Test("Test pro operator +", new Complex(1, 1) + new Complex(2, 2), new Complex(3, 3));
        TestComplex.Test("Test pro operator -", new Complex(2, 2) - new Complex(1, 1), new Complex(1, 1));
        TestComplex.Test("Test pro operator *", new Complex(2, 1) * new Complex(2, 1), new Complex(3, 4));
        TestComplex.Test("Test pro operator /", new Complex(2, 1) / new Complex(1, 1), new Complex(1.5, 1.5));
        TestComplex.Test("Test pro operator -u", -new Complex(1, 1), new Complex(-1, -1));

        double[] test = new Complex(2, 1).ToModArg();

        Console.WriteLine(new Complex(2, 1) == new Complex(2, 1));
        Console.WriteLine(new Complex(2, 1) != new Complex(2, 1));
        Console.WriteLine("mod " + test[0]);
        Console.WriteLine("arg " + test[1]);



    }


}

