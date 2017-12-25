kullanarak  System ;
using  System.Collections.Generic ;
 System.Linq kullanarak ;
 System.Text kullanarak ;

isim alanı  Kalitim2
{
    sınıfı  Çalışkan : Kisi
    {
        genel dize  kimliği = " ABC567EFG " ;
        public override void  BilgiAl () // Ana  s ı n ı fından  BilgiAl  sanal  metodu
           // değiştirilerek yeni bilgiler ekleniyor
        {
            // Temel sınıf GetInfo yöntemini çağırmak:
            base.BilgiAl ();
            Console.WriteLine ("Hesap Kimliği: {0} " , id);
        }
    }
}
