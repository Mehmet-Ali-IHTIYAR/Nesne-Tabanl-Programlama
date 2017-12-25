kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

ad alanı  Metotlar
{
    birinci sınıf  program
    {
        statik bool  benNerdeYnlisYaptim = false ;
        statik int  sayac = 0 ;
        static  void  Kontrol ( string  kadi , string  sfr )
        {

            while (sayac < 3 && benNerdeYnlisYaptim == false )
            {




                if (kadi == " ADMIN " || kadi == " Yönetici "
                    || kadi == " admin " )
                {
                    if (sfr == " 123Try " )
                    {
                        Console.WriteLine ( " Giriş Başarılı " );
                    }
                    Başka
                    {
                        Console.WriteLine ( " Şifre Hatalı " );
                        sayac ++;
                        Console.WriteLine ( " Hata Yaptınız: {0} " , sayac);
                    }

                }
                Başka
                {
                    Console.WriteLine ( " Kullanıcı Adı Hatalı " );
                    sayac ++;
                    Console.WriteLine ( " Hata Yaptınız: {0} " , sayac);
                }


                if (sayac> = 3 )
                {
                    Console.WriteLine ( " Şifre veya Kullanıcı Adı 3 Kez Hatalı Giritli ve Hesabınız bloke oldu :( " );
                    benNerdeYnlisYaptim = true ;

                }
                else  if (benNerdeYnlisYaptim == true )
                {
                    Console.WriteLine ( " Hesabınız Bloke Edildi " );
                }
                Başka
                {
                    Console.WriteLine ( " Kullanıcı Adınızı Giriniz: " );
                    kadi = Console.ReadLine ();
                    Console.WriteLine ( " Şifrenizi Girin: " );
                    sfr = Console.ReadLine ();
                }
            }
            
        }

        static  void  Ana ( string [] args )
        {

            Console.WriteLine ( " Kullanıcı Adınızı Giriniz: " );
            dize  k = Console.ReadLine ();
            Console.WriteLine ( " Şifrenizi Girin: " );
            string  s = Console.ReadLine ();

            Kontrol (k, s);


        }
    }
}
