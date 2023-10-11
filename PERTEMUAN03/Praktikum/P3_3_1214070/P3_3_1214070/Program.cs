using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_1214070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;

            while (ulang)
            {
                Console.WriteLine("Menu Pilihan:");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");
                Console.Write("Pilih menu (1/2): ");
                string pilihan = Console.ReadLine();

                if (pilihan == "1" || pilihan == "2")
                {
                    Console.Write("Masukkan panjang: ");
                    if (double.TryParse(Console.ReadLine(), out double panjang))
                    {
                        Console.Write("Masukkan lebar: ");
                        if (double.TryParse(Console.ReadLine(), out double lebar))
                        {
                            if (pilihan == "1")
                            {
                                double luas = panjang * lebar;
                                Console.WriteLine($"Luas Persegi Panjang: {luas}");
                            }
                            else
                            {
                                double keliling = 2 * (panjang + lebar);
                                Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input lebar tidak valid.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input panjang tidak valid.");
                    }
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia.");
                }

                Console.Write("Apakah Anda ingin mengulang? (Y/T): ");
                string ulangi = Console.ReadLine();
                if (ulangi.ToUpper() != "Y")
                {
                    ulang = false;
                }
            }
        }
    }
}
