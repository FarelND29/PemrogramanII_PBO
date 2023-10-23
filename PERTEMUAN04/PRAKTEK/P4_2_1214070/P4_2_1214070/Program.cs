using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214070
{
    internal class Tugas4
    {
            // Base class (class dasar)
        class Karyawan
        {
            // Field (bidang) private
            private string nama;
            private int usia;

            // Property (properti) publik untuk mengakses field
            public string Nama
            {
                get { return nama; }
                set { nama = value; }
            }

            public int Usia
            {
                get { return usia; }
                set { usia = value; }
            }

            // Constructor (konstruktor)
            public Karyawan(string nama, int usia)
            {
                this.nama = nama;
                this.usia = usia;
            }

            // Metode (method) virtual
            public virtual void Info()
            {
                Console.WriteLine($"Nama: {nama}, Usia: {usia} tahun");
            }
        }

        // Subclass (subclass) yang mewarisi Karyawan
        class Manajer : Karyawan
        {
            private string departemen;

            public string Departemen
            {
                get { return departemen; }
                set { departemen = value; }
            }

            // Constructor khusus untuk Manajer, menggunakan base constructor
            public Manajer(string nama, int usia, string departemen) : base(nama, usia)
            {
                this.departemen = departemen;
            }

            // Override metode Info dari superclass
            public override void Info()
            {
                Console.WriteLine($"Nama: {Nama}, Usia: {Usia} tahun, Departemen: {departemen}");
            }
        }

        class Program
        {
            static void Main()
            {
                Karyawan karyawan1 = new Karyawan("Farel Nouval", 21);
                Karyawan karyawan2 = new Manajer("Annisa Chintya", 21, "Keuangan");

                // Polymorphism: Memanggil metode Info() yang berbeda
                Console.WriteLine("Informasi Karyawan 1:");
                karyawan1.Info();

                Console.WriteLine("\nInformasi Karyawan 2:");
                karyawan2.Info();

                Console.ReadLine();
            }
        }
    }
    }      

