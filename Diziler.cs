kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

ad alanı  Diziler
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            int [] sayilar = yeni  int [ 10 ];
            int  elemanSayisi = sayilar.Length;
            string [] isimler = yeni  dizgi [ 5 ];
            Console.WriteLine ( " Eleman Sayısı: " + elemanSayisi);

            sayilar [ 5 ] = 100 ;
            SAYILAR [ 9 ] = 12457 ;

            Rasgele  r = yeni  Rasgele ();

            for ( int  i = 0 ; i <sayilar.Length; i ++)
            {
                sayilar [i] = r.İleri ( 100 );
                Console.WriteLine (SAYILAR [i]);
            }

            isimler [ 3 ] = " Ahmet " ;

            foreach ( dize isim in isimler)
                Console.WriteLine (isim);

            // Array.Clear (sayilar, 0, 10);

            //Array.Reverse(sayilar);

            Array.Sort (SAYILAR);
            Array.Reverse (SAYILAR);

            for ( int  i = 0 ; i <sayilar.Length; i ++)
            {
                Console.WriteLine (SAYILAR [i]);
            }



            string [] sehirler = yeni  dize [ 6 ] { " Ankara " , " Samsun " , " Tokat " , " Amasya " , " İstanbul " , " İzmir " };
            Console.WriteLine ( " Hangi Şaardensin Gardaş Kime Baktın ??: " );
            string  aranan = Console.ReadLine ();
           int  sirasi = Array.IndexOf (sehirler, aranan);

            Console.WriteLine ( " Aradığın şaare {0}. Ulaşmak ulaştı {1} " , sirasi + 1 , aranan);
        }
    }
}
