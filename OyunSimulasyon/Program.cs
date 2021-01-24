using System;
using System.Collections.Generic;

namespace OyunSimulasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Oyuncu> oyuncular = new List<Oyuncu>();
            string islemler = "1. müşteri oluşturma\n" +
                "2. oyun işlemleri";
            Console.WriteLine(islemler);
            while (true)
            {
                String secim = Console.ReadLine();
                if (secim.Equals("1"))
                {
                    string musteriTipleri = "1. Oyuncu(Bireysel)" +
                        "2. Mağaza(Kurumsal)";
                    Console.WriteLine(musteriTipleri);
                    Console.WriteLine("müşteri tipini seçiniz");
                    string secim2 = Console.ReadLine();
                    if (secim2.Equals("1"))
                    {
                        Oyuncu o1 = new Oyuncu();
                        o1.Adi = "Ayça";
                        o1.Soyadi = "Akdemir";
                        o1.Id = 1;
                        o1.DogumYili = 2000;
                        o1.TcNo = "122345";
                        o1.OyunAdedi = 1;
                        oyuncular.Add(o1);
                        Console.WriteLine(o1.Adi + " adlı oyuncu oluşturuldu");
                    }
                    if (secim2.Equals("2"))
                    {
                        Magaza o2 = new Magaza();
                        o2.MagazaAdi = "steam";
                        o2.Id = 1;
                        o2.OyunAdedi = 1;
                        
                        Console.WriteLine(o2.MagazaAdi + " adlı mağaza oluşturuldu");
                    }
                }
                if (secim.Equals("2"))
                {
                    Oyun oyun1 = new Oyun();
                    oyun1.OyunAdi = "mc";
                    oyun1.Fiyati = 50;
                    oyun1.Boyutu = 5;
                    oyun1.Id = 5;

                    OyunİslemleriManager oyunislemler = new OyunİslemleriManager();
                    oyunislemler.OyunAl(oyun1, oyuncular[0]);
                    Console.WriteLine("******************");
                    oyunislemler.yeniKampanyaGirisi("oyun içi 100tl");
                    oyunislemler.KampanyaGuncelleme("iki alana bir bedava");
                    oyunislemler.KAmpanyaSilme("iki alana bir bedava");
                }
            }
        }
    }
}
