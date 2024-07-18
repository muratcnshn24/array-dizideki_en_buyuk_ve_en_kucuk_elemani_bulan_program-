using System;
using System.Collections.Generic;
using System.Text;

namespace array_dizideki_en_buyuk_ve_en_kucuk_elemani_bulan_program_
{
    public class Dizi
    {
        ///<sammary>
        /// tek boyutlu dizi oluşturmak için kullanılan fonksiyondur.
        ///</sammary>
        ///<param name="Limit"> dizinin uzunluğunu belirtir </param>
        ///<returns> belirtilen uzunlukta rastgele sayıyılardan oluşmuş diziyi döner  </returns>
        public int[] Olustur(int Limit)
        {
            int[] sayilar = new int[Limit];
            Console.WriteLine("");
            for (int i = 0; i < Limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.WriteLine("{0,3}", sayilar[i]);
            }
            Console.WriteLine(""); // dizi karakterleri yan yana yazılsın diye alt ve üste bu kısmı yazıp diziyi  araya aldım
            return sayilar;

        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en büyük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb) eb = dizi[i];

            }
            return eb;
        }

        ///<sammary>
        ///  Parametre olarak aldığı dizideki en küçük elemanı döner.
        ///</sammary>
        ///<param name="Dizi"> Dizi </param>
        ///<returns></returns>
        public static int EnKucuk(int[] dizi)                  //statik yaparsan nesne üretmene gerek kalmaz
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek) ek = dizi[i];

            }
            return ek;
        }
    }
}
