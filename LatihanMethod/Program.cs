using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;
            Calculator calculator = new Calculator();
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil penjumlah: " + hasil);

            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil penjumlah overload " + hasil);

            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil penjumlah overload " + hasil);

            hasil = calculator.Perkalian(5, 2);
            CetakHasil("Hasil penjumlah ovserload " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}