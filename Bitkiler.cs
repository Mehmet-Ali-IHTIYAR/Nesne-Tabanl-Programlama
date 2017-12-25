kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

ad alanı  BitkiAlemi
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            Agac  kayin = yeni  Agac ( " Kayin " );
            Console.WriteLine ( " Benim Adım: " + kayin.Ad);
            kayin.FotoSentez ();
            for ( int  i = 0 ; i < 10 ; i ++) için
            kayin.Buyu ();
        }
    }
}
