namespace Piac
{
    public class Termek
    {
        public string Nev { get; }
        public int Mennyiseg { get; }
        public int Ar { get; }

        public Termek(string nev, int mennyiseg, int ar)
        {
            Nev = nev;
            Mennyiseg = mennyiseg;
            Ar = ar;
        }

        public override string ToString()
        {
            return $"{Nev} ({Mennyiseg}) - [{Ar}] : {{{Mennyiseg * Ar}}}";
        }
    }
}
