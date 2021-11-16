namespace Piac
{
    partial class Program
    {
        public class Arus
        {
            public string Nev { get; }
            public Termek[] Termekek { get; private set; }

            public Arus(string nev)
            {
                Nev = nev;
                Termekek = new Termek[0];
            }

            public void AruAtVetel(Termek termek)
            {
                Termek[] tmp = new Termek[Termekek.Length + 1];
                for (int i = 0; i < Termekek.Length; i++)
                {
                    tmp[i] = Termekek[i];
                }
                tmp[Termekek.Length] = termek;
                Termekek = tmp;
            }

            public override string ToString()
            {
                string tmp = $"{Nev} \n";
                for (int i = 0; i < Termekek.Length; i++)
                {
                    tmp += $" - '{Termekek[i].ToString()}' \n";
                }
                return tmp;
            }

            public int Vagyon()
            {
                int sum = 0;
                for (int i = 0; i < Termekek.Length; i++)
                {
                    sum += Termekek[i].Ar * Termekek[i].Mennyiseg;
                }
                return sum;
            }
            public static Arus Leggazdagabb(Arus[] arusok)
            {
                int idx = 0;
                int sumMax = arusok[0].Vagyon();
                for (int i = 1; i < arusok.Length; i++)
                {
                    int sum = arusok[i].Vagyon();
                    if (sum > sumMax)
                    {
                        sumMax = sum;
                        idx = i;
                    }
                }
                return arusok[idx];
            }
        }
    }
}
