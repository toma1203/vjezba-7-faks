using System;

namespace vjezba_7_4
{
    class Program
    {
        struct Skolarina
        {
            public string korisnik;
            public int ECTS;
            public double cijena_boda;
        }
        static Skolarina[] Unosniza(int n)
        {
            Skolarina[] nizskolarina = new Skolarina[n];
            for (int i = 0; i < nizskolarina.Length; i++)
            {
                do
                {
                    Console.WriteLine("unesi ime");
                    nizskolarina[i].korisnik = Console.ReadLine();
                } while (nizskolarina[i].korisnik.Length < 2);
                do
                {
                    Console.WriteLine("unesi ECTS bodove");
                    nizskolarina[i].ECTS = int.Parse(Console.ReadLine());
                } while (nizskolarina[i].ECTS < 0 && nizskolarina[i].ECTS > 60);
                do
                {
                    Console.WriteLine("unesi cijenu jednog boda");
                    nizskolarina[i].cijena_boda = double.Parse(Console.ReadLine());
                } while (nizskolarina[i].cijena_boda < 0);
            }
            return nizskolarina;
        }
        static Skolarina UnesiJedan()
        {
            Skolarina s;
            Console.WriteLine("unos korisnika");
            do
            {
                Console.WriteLine("unesi ime");
                s.korisnik = Console.ReadLine();
            } while (s.korisnik.Length < 2);
            do
            {
                Console.WriteLine("unesi ECTS bodove");
                s.ECTS = int.Parse(Console.ReadLine());
            } while (s.ECTS < 0 && s.ECTS > 60);
            do
            {
                Console.WriteLine("unesi cijenu jednog boda");
                s.cijena_boda = double.Parse(Console.ReadLine());
            } while (s.cijena_boda < 0);
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("unesi n");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 && n > 20);

            Skolarina[] niz = new Skolarina[n];
            for (int i = 0; i < n; i++)
                niz[i] = UnesiJedan();
            foreach (Skolarina k in niz)
                Console.WriteLine($"{k.korisnik} {k.cijena_boda} kn {k.ECTS}");

            double prosjek = 0;
            foreach (Skolarina s in niz)
                prosjek += s.ECTS;
            prosjek = prosjek / niz.Length;
            Console.WriteLine($"prosjek ectsova je {prosjek}");

            int najblizi = 0;
            double razlika = Math.Abs(niz[0].ECTS - prosjek);

            for (int i = 1; i < n; i++)
            {
                double r = Math.Abs(niz[i].ECTS - prosjek);
                if (r < razlika)
                {
                    razlika = r;
                    najblizi = i;
                }
            }
            Console.WriteLine($"najblizi prosjeku je {niz[najblizi].korisnik} {niz[najblizi].ECTS}");

            Console.ReadKey();
        }
    }
}
