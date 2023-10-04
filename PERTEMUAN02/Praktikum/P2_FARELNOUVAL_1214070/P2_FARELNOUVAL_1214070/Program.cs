using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Masukkan angka pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            double tambah = angka1 + angka2;
            Console.WriteLine($"Hasil pertambahan: {tambah}");

            double kurang = angka1 - angka2;
            Console.WriteLine($"Hasil pengurangan: {kurang}");

            double kali = angka1 * angka2;
            Console.WriteLine($"Hasil perkalian: {kali}");

            if (angka2 != 0)
            {
                double bagi = angka1 / angka2;
                Console.WriteLine($"Hasil pembagian: {bagi}");
            }
            else
            {
                Console.WriteLine("Pembagian oleh nol tidak diizinkan.");
            }

            Console.ReadLine();
        }
    }
}
