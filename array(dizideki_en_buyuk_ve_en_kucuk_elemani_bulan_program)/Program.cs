using System;

namespace array_dizideki_en_buyuk_ve_en_kucuk_elemani_bulan_program_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n degerini giriniz:");
            int Limit = Convert.ToInt32(Console.ReadLine());

           

            int[] sayilar = new Dizi().Olustur(Limit);

            Console.WriteLine("\n Dizinin En Büyük Elemani:{0}", Dizi.EnBuyuk(sayilar));
            Console.WriteLine("\n Dizinin En Küçük Elemani:{0}", Dizi.EnKucuk(sayilar));
        }

     

       
    }
}
