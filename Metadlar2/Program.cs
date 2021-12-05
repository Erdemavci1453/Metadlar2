using System;

namespace Metadlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 30;
            urun1.Aciklama = "Fransa Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Deveci Armudu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("......................");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

                

           

           




           

           
      
           




            
            



            
        }
    }
}
