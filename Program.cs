namespace ATM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sinif = new List<string>();
            int ogrenci = 0;
            Console.WriteLine("Araç Kaç Kişilik");
            int arac=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci Eklemek İçin 1");
            Console.WriteLine("Öğrenci Eklemeyi Durdurmak İçin 2");
            while (true)
            {
                int sec = 0;
                sec = Convert.ToInt32(Console.ReadLine());
                if (sec == 1)
                {
                    Console.WriteLine("Öğrenci İsmi Giriniz");
                    sinif.Add(Console.ReadLine());
                    ogrenci++;
                    Console.WriteLine("Devam etmek için 1, Durdurmak İçin 2'ye basın");

                }

               

                else if (sec == 2)
                {
                    Console.WriteLine("Ekleme İşlemi Bitti");
                    Console.WriteLine("Geziye Gidecek Öğrenci Sayısı" + sinif);
                    break;
                }
                
                else
                {
                    Console.WriteLine("Hatalı Değer Girdiniz");
                }
                
                if (arac< ogrenci)
                {
                    Console.WriteLine("sınır aşıldı");
                }
                
                
            }  
            Console.ReadLine();
        }
    }
}
