kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

ad alanı  OzYineli
{
    birinci sınıf  program
    {

        static  int  Topla ( int  n )
        {
            if (n == 0 ) dönüş  0 ;
            Başka
                dönüş n + Topla (n- 1 );
        }

        statik  uzun  Faktoriyel ( int  n )
        {
            if (n == 1 ) dönüş  1 ;
            Başka
                dönüş n * Faktoriyel (n - 1 );
        }

        static  void  Ana ( string [] args )
        {

            Console.WriteLine ( " Toplamını çıkar İstediğin Sayıyı: " );
            int  sayi = Convert.ToInt16 (Console.ReadLine ());

            int  sonuc = Topla (sayi);
            uzun  sonuçFak = Faktoriyel (sayi);

            Console.WriteLine ( " Toplam: {0} Faktoriyel: {1} " , sonuc, sonucuFak);


        }
    }
}
