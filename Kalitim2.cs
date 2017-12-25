kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

isim alanı  Kalitim2
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            Kisi  k = yeni  Kisi ();
            k.BilgiAl ();

            Calisan  c1 = yeni  calisan ();
            c1.BilgiAl ();

            Kisi  k1 = c1; // calisan Ana sınıf nesnesine içerisine atanabilir UpCasting

            k.BilgiAl ();

            c1 = ( Calisan ) k;

            c1.BilgiAl ();

        }
    }
}
