using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piac
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Arus dani = new Arus("Dani");
            Arus peter = new Arus("Péter");

            for (int i = 0; i < 3; i++)
            {
                dani.AruAtVetel(new Termek($"termek{i + 1}", 1, 10));
                peter.AruAtVetel(new Termek($"termek{i + 1}", 2, 20));
            }

            Console.WriteLine(dani.ToString());
            Console.WriteLine(peter.ToString());

            Console.WriteLine(Arus.Leggazdagabb(new Arus[] { dani, peter }).Nev);

            Arus levi = new Arus("Levi");
            levi.AruAtVetel(new Termek("Marlboro", 15, 2000));
            levi.AruAtVetel(new Termek("Palmal", 25, 1500));
            levi.AruAtVetel(new Termek("Multifitlter", 10, 1765));
            levi.AruAtVetel(new Termek("Rothmans", 30, 1450));
            Console.WriteLine(Arus.Leggazdagabb(new Arus[] { dani, levi, peter }).Nev);  ;
        }
    }
}
