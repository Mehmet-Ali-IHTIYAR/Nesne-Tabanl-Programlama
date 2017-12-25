kullanarak  System ;

ad alanı  KonrolYapi
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            
Konsol Yazısı             ( " Girdiğiniz Sayıya Kadar Olan Asal Sayıları Yazar: " );
            int  sayi = Convert.ToInt16 (Console.ReadLine ());
            Console.WriteLine ();
            bool  asalmi = doğru ;
            int  sayac = 0 ;
            for ( int  i = 2 ; i <= sayi; i ++)
            {
                for ( int  j = 2 ; j <i; j ++) için
                {
                    if (i% j == 0 )
                    {
                        asalmi = false ;
                        mola ;
                    }
                }
                if (asalmi == true )
                {
                    Console.Write (i + "  " );
                    sayac ++; 
                    if (sayac% 5 == 0 )
                        Console.WriteLine ();
                }
                asalmi = doğru ;
            }

            Console.WriteLine ( " ----- Yıldızları Yazdır --------- " );
            for ( int  i = 1 ; i <= 5 ; i ++) için
            {
                for ( int  j = 0 ; j <= 5 - i; j ++) için
                {
                    Console.Write ( " * " );
                }
                Console.WriteLine ();
            }

            Console.WriteLine ( " ----------------------------- " );
            int  yildizsayisi = 0 ;
            for ( int  a = 0 ; a < 10 ; a ++) için
            {
                
                for ( int  b = 10 ; b> 0 ; b--)
                {
                   if (a <b / 2 - a)
                        Console.Write ( "  " );
                   else  if (a> (b / 2 - a) && a <(b / 2 + a))
                        Console.Write ( " * " );
                   Başka
                        Console.Write ( "  " );
                    
                }
                Console.WriteLine ();
                yildizsayisi ++;
            } 

        }




    }
}
