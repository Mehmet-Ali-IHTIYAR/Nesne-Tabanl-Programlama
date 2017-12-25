kullanarak  System ;

ad alanı  Diziler
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            uzun [] tckimlik = yeni  uzun [ 3 ];
            tckimlik [ 0 ] = 12345678912 ;
            tckimlik [ 1 ] = 12366786772 ;
            tckimlik [ 2 ] = 45433678912 ;

            for ( int  i = 0 ; i <tckimlik.Length; i ++) için
               Console.WriteLine (tckimlik [i]);

            dize [] adlar =
                yeni  dize [] { " Ahmet " , " Ayşe " , " Fatma " , " Veli " };

            foreach ( dize reklam içinde Adlar)
                Console.Write (reklam + "  " );

            int [] sayilar = yeni  int [] { 12 , 55 , 32 , 64 , 84 , 22 , 44 };
            int [] kopya = yeni  int [sayilar.Length];

            Console.WriteLine ();

            for ( int  i = 0 ; i <sayilar.Length; i ++)
                kopya [i] = sayilar [i];

            foreach ( int i içinde kopya)
                Console.Write (i + "  " );



        }
    }
}
