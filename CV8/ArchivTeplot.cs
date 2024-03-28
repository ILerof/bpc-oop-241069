namespace CV08
{
    class ArchivTeplot
    {
        private SortedDictionary<double, RocniTeplota> _archiv;

        public void Load(string path)
        {
            StreamReader reader = File.OpenText(path);
            _archiv = new SortedDictionary<double, RocniTeplota>();
            double rok = 0;

            string radek;
            while ((radek = reader.ReadLine()) != null)
            {
                List<double> teploty = new List<double>();
                radek = radek.Replace(" ", "");
                List<string> values = radek.Split(':', ';').ToList();

                for (int i = 0; i < values.Count; i++)
                {
                    double cislo = Convert.ToDouble(values[i]);

                    if (i == 0) rok = cislo;
                    else
                    {
                        teploty.Add(cislo);
                    }
                }

                _archiv.Add(rok, new RocniTeplota(rok, teploty));
            }
        }
        public void Save(string path)
        {
            StreamWriter writer = File.CreateText(path);

            foreach (var item in _archiv.Values)
            {
                writer.Write("{0}: ", item.Rok);
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    if (i + 1 == item.MesicniTeploty.Count)
                    {
                        writer.Write("{0:0.0} ", item.MesicniTeploty[i]);
                    }
                    else
                        writer.Write("{0:0.0}; ", item.MesicniTeploty[i]);
                }
                writer.WriteLine();
            }
            Console.WriteLine("\nUlozeno");
            writer.Close();
        }

        public void Kalibrace(double number)
        {
            Console.WriteLine($"Kalibrace: {number}");
            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    item.MesicniTeploty[i] = item.MesicniTeploty[i] + number;
                }
            }
            TiskTeplot();
        }

        public void Vyhledej(int rok)
        {
            Console.WriteLine("Vyhledani: " + rok);
            if (_archiv.ContainsKey(rok))
            {
                Console.Write("{0}: ", _archiv[rok].Rok);
                for (int i = 0; i < _archiv[rok].MesicniTeploty.Count; i++)
                {
                    if (i + 1 == _archiv[rok].MesicniTeploty.Count)
                    {
                        Console.Write("{0:0.0} ", _archiv[rok].MesicniTeploty[i]);
                    }
                    else 
                        {
                            Console.Write("{0:0.0}; ", _archiv[rok].MesicniTeploty[i]);
                        }
                }
            }
            else
                Console.WriteLine("Nenalezeno");
        }

        public void TiskTeplot()
        {
            Console.WriteLine("Tisk teplot: ");
            foreach (var item in _archiv.Values)
            {
                Console.Write("{0}: ", item.Rok);
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    if (i + 1 == item.MesicniTeploty.Count)
                    {
                        Console.Write("{0:0.0} ", item.MesicniTeploty[i]);
                    }
                    else
                        Console.Write("{0:0.0}; ", item.MesicniTeploty[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void TiskPrumernychTeplot()
        {
            Console.WriteLine("Tisk prumernych rocnich teplot: ");
            foreach (var item in _archiv.Values)
            {
                Console.Write("{0}: ", item.Rok);
                Console.WriteLine("{0:0.0} ", item.PrumernaRocniTeplota);
            }
            Console.WriteLine();
        }

        public void TiskPrumernychMesicnichTeplot()
        {
            Console.Write("Prum.: ");
            List<double> prumerMesic = new List<double>() { 0 };
            for (int i = 0; i < 12; i++)
            {
                prumerMesic.Add(0);
            }

            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.MesicniTeploty.Count; i++)
                {
                    prumerMesic[i] += item.MesicniTeploty[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                prumerMesic[i] = prumerMesic[i] / _archiv.Keys.Count;
                if (i == 11)
                {
                    Console.Write("{0:0.0} ", prumerMesic[i]);
                }
                else 
                    { 
                        Console.Write("{0:0.0}; ", prumerMesic[i]); 
                    }
                
            }
            Console.WriteLine("\n");
        }

    }
}