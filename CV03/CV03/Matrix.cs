
        public class Matrix
        {
            double[,] matice;

            public Matrix(double[,] matice)
            {
                this.matice = matice;
            }

            public static Matrix operator +(Matrix a, Matrix b)
            {
                try
                {
                    var matrix = new Matrix(
                        new double[a.matice.GetLength(0), a.matice.GetLength(1)]);
                    for (int i = 0; i < a.matice.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matice.GetLength(1); j++)
                        {
                            matrix.matice[i, j] = a.matice[i, j] + b.matice[i, j];
                        }
                    }
                    return matrix;
                }
                catch
                {
                    Console.WriteLine("Chyba ve velikosti matice.");
                }

                return a;
            }
            public static Matrix operator -(Matrix a, Matrix b)
            {
                try
                {
                    var matrix = new Matrix(
                           new double[a.matice.GetLength(0), a.matice.GetLength(1)]);
                    for (int i = 0; i < a.matice.GetLength(1); i++)
                    {
                        for (int j = 0; j < a.matice.GetLength(0); j++)
                        {
                            matrix.matice[i, j] = a.matice[j, i] - b.matice[j, i];
                        }
                    }
                    return matrix;
                }
                catch
                {
                    Console.WriteLine("Chyba ve velikosti matice.");
                }
                return a;
            }
            public static Matrix operator *(Matrix a, Matrix b)
            {
                try
                {
                    var matrix = new Matrix(
                        new double[a.matice.GetLength(0), a.matice.GetLength(1)]);
                    var c = matrix.matice;
                    for (int i = 0; i < c.GetLength(0); i++)
                    {
                        for (int j = 0; j < c.GetLength(1); j++)
                        {
                            c[i, j] = 0;
                            for (int k = 0; k < a.matice.GetLength(1); k++)
                                c[i, j] = c[i, j] + a.matice[i, k] * b.matice[k, j];
                        }
                    }
                    matrix.matice = c;
                    return matrix;
                }
                catch
                {
                    Console.WriteLine("Chyba ve velikosti matice.");
                }

                return a;

            }
            public static bool operator ==(Matrix a, Matrix b)
            {
                try
                {
                    for (int i = 0; i < a.matice.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matice.GetLength(1); j++)
                        {
                            if (a.matice[i, j] != b.matice[i, j]) return false;
                        }
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
            public static bool operator !=(Matrix a, Matrix b)
            {
                try
                {
                    for (int i = 0; i < a.matice.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matice.GetLength(1); j++)
                        {
                            if (a.matice[i, j] != b.matice[i, j]) return true;
                        }
                    }
                }
                catch
                {
                    return false;
                }
                return false;
            }
            public static Matrix operator -(Matrix a)
            {
                var matrix = new Matrix(
                        new double[a.matice.GetLength(0), a.matice.GetLength(1)]);
                for (int i = 0; i < a.matice.GetLength(1); i++)
                {
                    for (int j = 0; j < a.matice.GetLength(0); j++)
                    {
                        matrix.matice[j, i] = a.matice[j, i] * (-1);
                    }
                }

                return matrix;
            }



        public double Determinant()
        {
            try
            {
                if (matice.GetLength(0) != matice.GetLength(1) || matice.GetLength(0) > 3 || matice.GetLength(1) > 3) { 
                    Console.WriteLine("Rozmery matice je vetsi nez 3x3");
                    return 0;
                } 
                if (matice.GetLength(0) == matice.GetLength(1) &&
                    matice.GetLength(1) == 2)
                {
                    return matice[0, 0];
                }
                else if (matice.GetLength(0) == matice.GetLength(1) &&
                        matice.GetLength(1) == 2)
                {
                    return matice[0, 0] * (matice[1, 1] - matice[0, 1] * matice[1, 0]);

                }
                else if (matice.GetLength(0) == matice.GetLength(1) &&
                        matice.GetLength(1) == 3)
                {
                    var determinant = matice[0, 0] * (matice[1, 1] * matice[2, 2] - matice[1, 2] * matice[2, 1]) -
                                      matice[0, 1] * (matice[1, 0] * matice[2, 2] - matice[1, 2] * matice[2, 0]) +
                                      matice[0, 2] * (matice[1, 0] * matice[2, 1] - matice[1, 1] * matice[2, 0]);

                    return determinant;
                }
            }
            catch
            {
                throw new Exception("Rozmery matice je vetsi nez 3x3");
            }
            return 0;
        }


        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    if (j != matice.GetLength(0)) output += $"{matice[i, j]},";
                }
                output += Environment.NewLine;
            }

            return output;
        }

    }