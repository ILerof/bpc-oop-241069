class Autoradio
{
	private double naladenyKmitocet;
	private bool radioZapnuto = false;
	private Dictionary<int, double> vsechnyKmitocty = new Dictionary<int, double>();

	public void zapnoutRadio(bool OnOff)
	{
		if (OnOff)
		{
			radioZapnuto = true;
		}
		else
			radioZapnuto = false;
	}

	public void nastavPredvolbu(int cislo, double kmitocet)
	{
		vsechnyKmitocty.Add(cislo, kmitocet);
    }

	public void preladNaPredvolbu(int cislo)
	{
		if (vsechnyKmitocty.ContainsKey(cislo))
		{
			naladenyKmitocet = vsechnyKmitocty[cislo];
		}
		else
			throw new Exception("Kmitocet nenajdeny");
	}

	public override string ToString()
	{
		if (radioZapnuto)
		{
			return String.Format($"Zapnuto:{radioZapnuto}, Naladeny kmitocet:{naladenyKmitocet}");
		}
		else
			return String.Format($"Zapnuto:{radioZapnuto}");
	}
}