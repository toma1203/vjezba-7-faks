using System;

namespace vjezba_7_2
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
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("unesi n");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 && n > 20);

            Skolarina[] nizskolarina = Unosniza(n);

            foreach (Skolarina k in nizskolarina)
                Console.WriteLine($"{k.korisnik} {k.cijena_boda} kn {k.ECTS}");

            Console.ReadKey();
        }
    }
}
