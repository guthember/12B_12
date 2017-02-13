using System;

namespace osztaly01
{
           
    class Negyzet
    {
        public int a;

        public int Terulet()
        {
            return a * a;
        }

        public int Kerulet()
        {
            return 4 * a;
        }
    }

    class Kor
    {
        private int x;
        private int y;
        private int r;

        public Kor(int sugar)
        {
            x = 0;
            y = 0;
            if (sugar < 1)
            {
                r = 10;
            }
            else
            {
                r = sugar;
            }
        }

        public Kor(int x1, int y1, int r1) 
        {
            x = x1;
            y = y1;
            if (r1 < 1)
            {
                r = 10;
            }
            else
            {
                r = r1;
            }
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetR()
        {
            return r;
        }
      
        public void Kiir()
        {
            Console.WriteLine("x: {0}",x);
            Console.WriteLine("y: {0}",y);
            Console.WriteLine("r: {0}",r);
        }

        public double Terulet() 
        {
            double ter = r * r * Math.PI;
            return ter; 
        }
        public double Kerulet() 
        {
            double ker = 2 * r * Math.PI;
            return ker; 
        }
    }

    class Program
    {
        static void Main()
        {
            Kor k1 = new Kor(100);
            Negyzet n1 = new Negyzet();
            Teglalap t1 = new Teglalap();

            
            //Console.Write("Kérem a kör sugarát: ");
            //k1.r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A sugár: {0}",k1.GetR());
            Console.WriteLine(k1.Kerulet());
            Console.WriteLine(k1.Terulet());

            Console.Write("Kérem a négyzet oldalát: ");
            n1.a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Terület: {0}",n1.Terulet());
            Console.WriteLine("Kerület: {0}",n1.Kerulet());

            Console.Write("Kérem a téglalap \"a\" oldalát: ");
            t1.a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a téglalap \"b\" oldalát: ");
            t1.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terület: {0}", t1.Terulet());
            Console.WriteLine("Kerület: {0}", t1.Kerulet());




            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
