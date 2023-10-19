using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_1
{
    internal class Inheirtance
    {
    }

    public class Car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }
        public void Klakson2()
        {
            Console.WriteLine("TELOLET!!!!");
        }
    }

    class Civic : Car
    {
        public Civic()
        {
            Roda = 4;
        }
        public void Klakson ()
        {
            Console.Write("Biiiimmmm......!!!!!!");
        }
    }
}
