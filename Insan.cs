kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

isim-alanı  Kalitim
{
    sınıf  Insan
    {
        halk  Insan (string isim)
        {
            Ad = isim; Boy = 1.5 ; Kilo = 55 ; _yas = 12 ;
        }
        genel dizge  Reklam { get ; ayarlayın ; }
        genel çift  Erkek { get ; ayarlayın ; }
        halka açık iki kat  Kilo { get ; ayarlayın ; }
        Özel int  _yas ;
        kamu int  Yas
        {
            olsun { return _yas; }
            set
            {
                if ( değer > 150 || değer < 0 )
                    _yas = 0 ;
                Başka
                    _yas = değer ;
            }
        }

        kamu  boşluğu  BilgiYaz ()
        {
            Console.WriteLine (Reklam + "  " + Yas + "  " + Boy + "  " + Kilo);
        }
    }
}
