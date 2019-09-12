using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volumebalok()
        {
            int panjang, lebar, tinggi;

            Console.WriteLine("masukkan nilai Volume Balok");
            Console.WriteLine("---------------------------");

            Console.Write("masukkan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume balok adalah : "+volume);
            Console.Write("   ");
      }
            
            
            public void volumekubus()
            {
                int sisi;

                Console.WriteLine("menghitung volume kubus");
                Console.WriteLine("-----------------------");

                Console.Write("masukkan nilai sisi : ");
                sisi = Convert.ToInt32(Console.ReadLine());

                int volume = sisi * sisi * sisi;

                Console.WriteLine("volume kubus adalah : "+volume);
                Console.Write("    ");
        }
    }
}