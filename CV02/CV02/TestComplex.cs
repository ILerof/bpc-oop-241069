
    public class TestComplex
    {
        public static void Test(String Testname, Complex a, Complex b)
        {
            Console.Write($"{Testname} ");
            var epsilon = 0.000001;
            if (Math.Abs(a.Realna - b.Realna) < epsilon &&
                Math.Abs(a.Imaginarni - b.Imaginarni) < epsilon)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Chyba \n");
                Console.WriteLine($"Skutecna hodnota:{a}");
                Console.WriteLine($"Ocekavana hodnota:{b}");
            }
        }

}
