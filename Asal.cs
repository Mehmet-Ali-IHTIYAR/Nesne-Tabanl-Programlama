kullanarak  System ;

 Asal ad alanı
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {

            Console.WriteLine ( " Bir Sayi Girin " );
            int  sayi = Convert.ToInt32 (Console.ReadLine ());
            bool  asalmi = doğru ;
            int  sayac = 0 ;

            for ( int  i = 2 ; i <sayi; i ++)
            {
                for ( int  j = 2 ; j <i; j ++) için
                {
                    if (i% j == 0 )
                    {
                        asalmi = false ;
                        mola ;
                    }
                   
                }
                 // Asal ise sayacı bir artırım
                if (asalmi! = false ) {
                    sayac ++;
                    if (sayac% 5 ! = 0 )
                        Console.Write (i + "  " );
                    Başka
                        Console.WriteLine (i)
                }
                   
                asalmi = doğru ;
            }


        }
    }
}
