using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3368
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Paijo", 190302123, 3000000);
            Karyawan karyawan2 = new Karyawan("Jono", 190302124, 2000000);

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");

            karyawan1.Menampilkan(1, karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            karyawan2.Menampilkan(2, karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%");
            Console.WriteLine();

            
            karyawan1.PeningkatanGaji(karyawan1.GajiBulanan);
            karyawan2.PeningkatanGaji(karyawan2.GajiBulanan);

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            karyawan1.Menampilkan(1, karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            karyawan2.Menampilkan(2, karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);


            Console.ReadKey();
        }
    }
}
