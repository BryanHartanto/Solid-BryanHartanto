using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luaspersegi()
        {
            int sisi;

            Console.WriteLine("masukkan nilai sisi : ");
            Console.WriteLine("----------------------");

            Console.Write("Masukkan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("Luas persegi adalah : "+luas);
            Console.WriteLine("     ");
        }
        public void luassegitiga()
        {
            int alas, tinggi;

            Console.WriteLine("menghitung luas segitiga");
            Console.WriteLine("-------------------------");

            Console.Write("masukkan nilai alas : ");
            alas=Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai tinggi : ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            int luas= alas * tinggi / 2;

            Console.WriteLine("Luas segitiga adalah "+luas);
            Console.WriteLine("     ");
        }

        public void luaslingkaran()
        {
            int jari;

            Console.WriteLine("masukkan nilai jari-jari");
            Console.WriteLine("------------------------");

            Console.Write("masukkan nilai jari-jari : ");
            jari = Convert.ToInt32(Console.ReadLine());

            double luas= jari*jari*3.14;
            Console.WriteLine("Luas lingkaran adalah : "+luas);
            Console.WriteLine("  ");

            
        }
    }
}