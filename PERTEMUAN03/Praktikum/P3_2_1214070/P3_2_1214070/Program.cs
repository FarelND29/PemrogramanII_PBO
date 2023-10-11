using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di program pembuatan syair lagu 'Anak Ayam'");

            bool ulang;
            do
            {
                int N;

                do
                {
                    Console.Write("Masukkan jumlah anak ayam (1-10): ");
                    if (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > 10)
                    {
                        Console.WriteLine("Nilai Tidak Boleh Dibawah 0 atau Diatas 10");
                    }
                } while (N < 1 || N > 10);

                BuatSyairAnakAyam(N);

                Console.Write("Ingin mengulang? (y/n): ");
                ulang = (Console.ReadLine().ToLower() == "y");
            } while (ulang);
        }

        static void BuatSyairAnakAyam(int N)
        {
            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine($"Anak ayam turun {i}, mati satu tinggal {i - 1}");
            }

            Console.WriteLine("Anak ayam turun 0, mati satu tinggal Induknya");
        }
    }
}

