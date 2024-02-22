
class Program
    {
        static void Main(string[] args)
        {
            double[,] matice1 = new double[,] {
                { 1, 5, 5 },
                { 3, 4, 5 },
                { 5, 6, 5 }
            };
            double[,] matice2 = new double[,] {
                { 1, 5, 5 },
                { 3, 4, 5 },
                { 5, 6, 5 }
            };

            Matrix m1 = new Matrix(matice1);
            Matrix m2 = new Matrix(matice2);

      

            Console.WriteLine("Scitani:");
            Console.WriteLine(m1 + m2);
            Console.WriteLine("Odecitani:");
            Console.WriteLine(m1 - m2);
            Console.WriteLine("Nasobeni:");
            Console.WriteLine(m1 * m2);

            Console.WriteLine("Rovna se:");
            Console.WriteLine(m1 == m2);
            Console.WriteLine("");
            Console.WriteLine("Nerovna se:");
            Console.WriteLine(m1 != m2);
            Console.WriteLine("");


            Console.WriteLine("Unarni matice:");
            Console.WriteLine(-m1);
            Console.WriteLine("Determinant:");
            Console.WriteLine(m1.Determinant());

        }
    }