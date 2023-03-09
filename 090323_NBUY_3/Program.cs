using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _090323_NBUY_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region ref kdv dondurme
            /* kdv uygulama metdou ekmek urunlerıne %1 kdv,kırtasiye %8, elektriklilere %18,kdv uygula metoduna parametre olarak indirim oranı
    gonderilecek gonderılen ındıırm oranına gore ındı*ygulanacak

    int indirim = 0;
    Console.WriteLine("Urun Secimi Yap");
    Console.WriteLine("1-ekmek\n2-kırtasiye\n3-elektrikli");
    Console.WriteLine();
    string secim=Console.ReadLine();
    Console.WriteLine();

    kdvuygula(secim);

    static void kdvuygula(string secim)
    {
        if (secim=="1")
        {
            int fiyat = 100;
            double kdv = 0.01;
            Console.WriteLine("fiyat:"+" "+(fiyat+(fiyat*kdv)));
        }
        else if (secim=="2")
        {
            int fiyat = 100;
            double kdv = 0.08;
            Console.WriteLine("fiyat:" + " " + (fiyat + (fiyat * kdv)));
        }
        else if (secim == "3")
        {
            int fiyat = 100;
            double kdv = 0.18;
            Console.WriteLine("fiyat:" + " " + (fiyat + (fiyat * kdv)));
        }

    }*/
            #endregion

            #region Ürüne göre kdv alma ref değeri ile
            /*{
                                decimal kdvOranı = 0;

                                Console.Write("Unlu mamul için 1, kırtasiye için 2, diğer ürünler için 3ü tuşlayın: ");
                                int urun = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Ürünün fiyatını giriniz: ");
                                decimal urunFiyati = Convert.ToInt32(Console.ReadLine());

                                decimal maliyet = FiyatHesapla(urun, ref kdvOranı, urunFiyati);
                                Console.WriteLine("Aldığınız ürünün toplam maliyeti: " + maliyet);

                            }


                            static decimal FiyatHesapla(int urun, ref decimal kdvOranı, decimal urunFiyati)
                            {

                                if (urun == 1)
                                {
                                    kdvOranı = 1;
                                    urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
                                }
                                else if (urun == 2)
                                {
                                    kdvOranı = 8;
                                    urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
                                }
                                else if (urun == 3)
                                {
                                    kdvOranı = 18;
                                    urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                }
                                return urunFiyati;
                            }*/
            #endregion

            #region metodda sabit değer verildiğinde değer girilmez ise sabit değer kullanılır. Değer verilirse, verilen değer kullanılır.
            //birinci değer sabitlenirse, ikinci değerde sabitlenmek zorunda.
            /*  KdvHesapla(7000, 8);
              KdvHesapla(8500);

              static void KdvHesapla(decimal fiyat, int kdv = 18)
              {
                  fiyat = fiyat + fiyat * kdv / 100;
                  Console.WriteLine(fiyat);
              } */
            #endregion

            #region params anahtarı ile metod içerisine dizi atılır .

            /* Console.WriteLine(topla(8, 6, 7, 3, 4));

             }

             private static int topla(params int[] x)
             {
                 return x.Sum();
             } */
            #endregion



        }

    }
}
