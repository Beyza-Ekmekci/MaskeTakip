 using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1  = new Vatandas();
            SelamVer(isim: "Beyza");
            SelamVer(isim: "Ayşe");
            SelamVer();
           

            //Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "beyz";
            ogrenciler[1] = "engin";
            ogrenciler[2] = "kerem";
            for (int i =0;i<ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new [] { "ankara", "istanbul", "izmir" };
            string[] sehirler2 = new []{ "antalya", "diyarbakır", "afyon" };
            sehirler2 = sehirler1;
            sehirler2[0] = "adana";
            Console.WriteLine(sehirler1[0]);
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
           

        }
     

        static void SelamVer(string isim= " No Name")
        {
            Console.WriteLine("Merhaba"+ isim);
        }
        static int topla(int sayi1 = 5, int sayi2 =10 )
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc.ToString());
            return sonuc;
        }
       
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }

    


}
