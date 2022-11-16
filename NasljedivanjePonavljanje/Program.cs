using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjePonavljanje
{
    class GeometrijskiLik
    {
        int brojStranica;
        double[] stranice = new double[10];
        public int BrojStranica { get => brojStranica; set => brojStranica = value; }
        public double[] Stranice { get => stranice; set => stranice = value; }

        public virtual void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Napišite duljina " + (i+1) + ". stranica.");
                Stranice[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double opseg = 0;
            for(int i = 0; i < this.BrojStranica; i++)
            {
                opseg += this.Stranice[i];
            }
            return opseg;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut() {
            BrojStranica = 3;
        }
    }
    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Upišite Duljiona stranica Trokuta - ");
            trokut.UcitajStranice();
            Console.WriteLine("Opseg Trokuta je " + trokut.Opseg() + ".");
            Console.WriteLine("\r\nUpišite Duljiona stranica Cetverokut - ");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg Cetverokut je " + cetverokut.Opseg() + ".");

            Console.ReadKey();
        }
    }
}
