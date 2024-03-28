namespace CV08
{
    class RocniTeplota
    {
        private double rok;
        private List<double> mesicniTeploty;
        private double maxTeplota;
        private double minTeplota;

        public RocniTeplota(double rok, List<double> teploty)
        {
            this.rok = rok;
            mesicniTeploty = new List<double>();
            mesicniTeploty = teploty;
        }

        public int pocet()
        {
            return mesicniTeploty.Count;
        }

        public double Rok
        {
            get => rok;
            set => rok = value; 
        }

        public List<double> MesicniTeploty
        {
            get => mesicniTeploty;
            set => mesicniTeploty = value;
        }

        public double MaxTeplota
        {
            get
            {
                maxTeplota = mesicniTeploty[0];
                foreach (double teplota in mesicniTeploty)
                {
                    if (teplota > maxTeplota)
                    {
                        maxTeplota = teplota;
                    }
                }
                return maxTeplota;
            }
        }

        public double MinTeplota
        {
            get
            {
                minTeplota = mesicniTeploty[0];
                foreach (double teplota in mesicniTeploty)
                {
                    if (teplota < minTeplota)
                    {
                        minTeplota = teplota;
                    }
                }
                return minTeplota;
            }
        }

        public double PrumernaRocniTeplota
        {
            get => mesicniTeploty.Average();
                
        }

    }
}