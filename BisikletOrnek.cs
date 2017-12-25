kullanarak  System ;

ad alanı  BisikletUygulama
{

    sınıf  Bisiklet
    {
         int hiz , vites , vitesSayısı , tekerCapi ; // Varsayılan özel
        halk Bisiklet () // Kurucu  metod
        {
            vitesSayısı = 6 ;
        }
        public  Bisiklet (int v) // kurucu metod aşırı yükleme
        {
            vitesSayısı = v;
        }
        kamusal  boşluk  Hizlan ( int  artis ) {
            hiz + = artis;
        }
        kamu  geçersiz  FrenYap ( int  azalis ) {
            hiz - = azalis;
        }
        public  void  VistesDegistir ( int  yeniDeger ) {
            vites = yeniDeger;
        }
        kamusal  void  bilgiYaz () {
            Console.WriteLine ( " Şu anki hiziniz: {0} " , hiz);
            Console.WriteLine ( " Şu anki vitesiniz: {0} " , vites);
            Console.WriteLine ( " En yüksek vites {0}: " , vitesSayisi);
        }
    }

    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            Bisiklet  b1 = yeni  Bisiklet ();
           
            b1.Hizlan ( 10 );
            b1.VistesDegistir ( 3 );
            b1.BilgileriYaz ();
            b1.FrenYap ( 5 );
            b1.VistesDegistir ( 2 );
            b1.BilgileriYaz ();
           
        }
    }
}
