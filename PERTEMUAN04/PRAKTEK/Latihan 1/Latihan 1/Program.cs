using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_1
{
    public class Program
    {
        public void Tes(string a, bool g)
        {
            Console.WriteLine("tes");
        }


        //Objek
        static void Main(string[] args)
        {
            Mobil SuatuMobil = new Mobil(); //untuk melihat mobil pake ctrl+klik mobil
            Mobil MobilSaya = new Mobil() 
            { 
                nama = "Lamborghini", 
                kecepatan = 10, 
                bensin = 30000, 
                posisi = 0 
            };
            MobilSaya.maju();
            Console.WriteLine(SuatuMobil.nama);
            Console.WriteLine(SuatuMobil.bensin);

            Console.WriteLine(MobilSaya.nama);
            Console.WriteLine(MobilSaya.bensin);
            //menambah objek MobilAnda
            Mobil MobilAnda = new Mobil("Nissan", 300, 5000);
            MobilAnda.maju();
            Console.WriteLine(SuatuMobil.nama);
            Console.WriteLine(SuatuMobil.bensin);

            Console.WriteLine(MobilAnda.nama);
            Console.WriteLine(MobilAnda.bensin);
            //penambahan properti
            PropertyTest p = new PropertyTest();
            p.Materi = "Bahasa Pemrograman C#";
            Console.WriteLine(p.Materi);

            Person ps = new Person();
            ps.Nilai = 100;
            Console.WriteLine(ps.Nilai);

            //penambahan inheritance
            Civic c = new Civic();
            Console.WriteLine(c.Roda);
            c.Klakson();

            Civic cv = new Civic();
            cv.Klakson2();

            //Polymorphism
            Bentuk l =new Lingkaran();
            l.Gambar();
            //Ouputs "Menggambar Lingkaran.."

            Bentuk psg = new Persegi();
            psg.Gambar();
            //Outputs "Menggambar Persegi..."
        }
    }
}
