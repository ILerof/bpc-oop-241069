namespace CV09
{
    class Calculator
    {
        private Stav _stav = Stav.PrvniCislo;
        public String Display { get; set; }
        public String Memory { get; set; }

        private string one = "";
        private Operace operation;
        private string two = "";
        private string answer = "";

        public void Tlacitko(String btn)
        {

            var cislo = "";

            switch (btn)
            {
                case "0":
                    cislo += "0";
                    break;
                case "1":
                    cislo += "1";
                    break;
                case "2":
                    cislo += "2";
                    break;
                case "3":
                    cislo += "3";
                    break;
                case "4":
                    cislo += "4";
                    break;
                case "5":
                    cislo += "5";
                    break;
                case "6":
                    cislo += "6";
                    break;
                case "7":
                    cislo += "7";
                    break;
                case "8":
                    cislo += "8";
                    break;
                case "9":
                    cislo += "9";
                    break;
                case ".":
                    cislo += ".";
                    break;
                case "+":
                    _stav = Stav.Operace;
                    operation = Operace.Plus;
                    break;
                case "-":
                    _stav = Stav.Operace;
                    operation = Operace.Minus;
                    break;
                case "*":
                    _stav = Stav.Operace;
                    operation = Operace.Krat;
                    break;
                case "/":
                    _stav = Stav.Operace;
                    operation = Operace.Deleni;
                    break;
                case "=":
                    _stav = Stav.Vysledek;
                    answer = FindAnswer();
                    Display = answer;
                    one = answer;
                    two = "";
                    answer = "";

                    break;
                case "+-":
                    if (Display != "")
                    {
                        if (_stav == Stav.PrvniCislo)
                        {
                            var tmp = Convert.ToDouble(one) * -1;
                            one = "" + tmp;
                        }
                        if (_stav == Stav.DruheCislo)
                        {
                            var tmp = Convert.ToDouble(two) * -1;
                            two = "" + tmp;
                        }
                    }
                    break;

                case "CE":
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = "";
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = "";
                        Display = two;
                    }

                    break;
                case "C":
                    _stav = Stav.PrvniCislo;
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                    break;
                case "<--":
                    if (_stav == Stav.PrvniCislo && one != null && one.Length > 0)
                    {
                        one = one.Substring(0, one.Length - 1);
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo && two != null && two.Length > 0)
                    {
                        two = one.Substring(0, two.Length - 1);
                        Display = two;
                    }

                    break;

                case "MS":
                    Memory = Display;
                    break;

                case "MR":
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = Memory;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = Memory;
                    }

                    Display = Memory;
                    break;

                case "MC":
                    Memory = "";
                    break;

                default:
                    break;

            }

            switch (_stav)
            {
                case Stav.PrvniCislo:
                    if (cislo.Contains('.'))
                    {
                        if (!one.Contains('.'))
                        {
                            if (one.Length >= 1)
                            {
                                one += cislo;
                            }
                            else
                            {
                                one = "0.";
                            }
                        }
                    }
                    else
                    {
                        one += cislo;
                    }
                    Display = one;
                    break;
                case Stav.DruheCislo:
                    if (cislo.Contains('.'))
                    {
                        if (!two.Contains('.'))
                        {
                            if (two.Length >= 1)
                            {
                                two += cislo;
                            }
                            else
                            {
                                two = "0.";
                            }
                        }
                    }
                    else
                    {
                        two += cislo;
                    }
                    Display = two;
                    break;
                case Stav.Operace:
                    _stav = Stav.DruheCislo;
                    break;
                case Stav.Vysledek:
                    _stav = Stav.PrvniCislo;
                    break;
            }



        }

        private enum Operace
        {
            Plus,
            Minus,
            Krat,
            Deleni
        };

        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };

        private string FindAnswer()
        {
            double o, t;

            string stringifiedOne = one, stringifiedTwo = two;

            if (one != null && one.EndsWith('.'))
            {
                stringifiedOne = one.Substring(0, one.Length - 1);
            }

            if (one != null && one.EndsWith('.'))
            {
                stringifiedTwo = two.Substring(0, two.Length - 1);
            }

            bool validO = double.TryParse(stringifiedOne, out o);
            bool validT = double.TryParse(stringifiedTwo, out t);
            if (!validO)
            {
                o = 0;
            }

            if (!validT)
            {
                t = 0;
            }

            double ans = 0;
            Console.WriteLine($"one: {one} \n two: {two} \n stringifiedOne: {stringifiedOne}\n stringifiedTwo: {stringifiedTwo}\n validO: {validO}\n validT: {validT}\n o: {o}\n t: {t}");

            switch (operation)
            {
                case Operace.Plus:
                    ans = o + t;
                    break;
                case Operace.Minus:
                    ans = o - t;
                    break;
                case Operace.Krat:
                    ans = o * t;
                    break;
                case Operace.Deleni:
                    ans = o / t;
                    break;
            }

            return $"{ans}".Replace(",", ".");
        }

    }


}