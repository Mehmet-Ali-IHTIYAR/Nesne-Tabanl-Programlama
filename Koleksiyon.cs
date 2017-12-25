kullanarak  System ;
 System.Collections kullanarak ;

ad alanı  Koleksiyon
{
    birinci sınıf  program
    {
        static  void  Ana ( string [] args )
        {
            // Kuyruk Oluşturmak 
            Sıra  ku = yeni  Sıra ();
            ku.Arama ( " IlkOkul " );
            ku.Acilika ( " Ortaokul " );
            ku.Görüntü ( " Lise " );
            ku.Görüntü ( " On Lisans " );
            ku.Görüntü ( " Lisans " );
            ku.Görüntü ( " Yuksek Lisans " );
            ku.Görüntü ( " Doktora " );

            Console.WriteLine (. Ku.Dequeue () .ToString ());
            Console.WriteLine (. Ku.Dequeue () .ToString ());
            Console.WriteLine (. Ku.Dequeue () .ToString ());

            IEnumerator  indeks = ku.GetEnumerator ();

            while (indeks.MoveNext ())
            {
                Console.WriteLine ( " O anki seviye " +
                    indeks.Current.ToString ());
            }

             Masa yığını = yeni  yığın ();

            masa.Push ( " tabak_1 " );
            masa.Push ( " tabak_2 " );
            masa.Push ( " tabak_3 " );
            masa.Push ( " tabak_4 " );
            masa.Push ( " tabak_5 " );
            masa.Push ( " tabak_6 " );

            Console.WriteLine ( " Pop yapilan deger: " + masa.Pop (). ToString ());
            Console.WriteLine ( " Pop yapilan deger: " + masa.Pop (). ToString ());
            indeks = masa.GetEnumerator ();
            while (indeks.MoveNext ())
            {
                Console.WriteLine (indeks.Current.ToString ());
            }


            Hashtable  openWith = yeni  Hashtable ();

            // Karma tabloya bazı öğeler ekleyin. Hayır
            // çift anahtarlar, ancak bazı değerler kopyalar.
            openWith.Add ( " txt " , " notepad.exe " );
            openWith.Add ( " bmp " , " paint.exe " );
            openWith.Add ( " dib " , " paint.exe " );
            openWith.Add ( " rtf " , " wordpad.exe " );

            // Add yöntemi, yeni anahtar varsa bir istisna atar 
            // zaten karma tabloda.
              // Hata Yakalama'yı deneyin
            {
                openWith.Add ( " txt " , " winword.exe " );
            }
            yakalamak   // Hata Yakala ve kodları çalıştır
            {
                Console.WriteLine ( " \" txt \ " anahtarı zaten mevcut. " );
            }




            ArrayList  elemanlar = new  ArrayList ();
            elemanlar.Add ( " Ahmet " );
            elemanlar.Add ( 154 );
            elemanlar.Add ( 545.548 );
            elemanlar.Add ( true );
            foreach ( nesne O içinde elemanlar)
                Console.Write (o.ToString () + "  " );

        }
    }
}
