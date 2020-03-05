using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim, kisakenar, uzunkenar, yukseklik, alttaban, usttaban, yaricap, kenarsayisi;
            int x, v, t;
            float pi = 3.14f;
            Console.Write("Hangi hesaplamayı yapmak istiyorsunuz?\n\n 1.Dikdörtgenin Alanı\n 2.Karenin Alanı \n 3.Üçgenin Alanı \n 4.Yamuğun Alanı \n 5.Paralelkenar \n 6.Silindirin Hacmi \n 7.Çokgen İç Açılar Toplamı \n 8.Hareket Problemleri \n\n İstediğinizin numarasını yazıp 'ENTER' a basıp devam edin.\n\n");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("\n---------------------------DİKDÖRTGEN ALANI---------------------------");
                    break;

                case 2:
                    Console.Write("\n---------------------------KARENİN ALANI---------------------------");
                    break;

                case 3:
                    Console.Write("\n---------------------------ÜÇGENİN ALANI---------------------------");
                    break;

                case 4:
                    Console.Write("\n---------------------------YAMUĞUN ALANI---------------------------");
                    break;
                case 5:
                    Console.Write("\n---------------------------PARALELKENAR ALANI---------------------------");
                    break;

                case 6:
                    Console.Write("\n---------------------------SİLİNDİRİN HACMİ---------------------------");
                    break;

                case 7:
                    Console.Write("\n---------------------------ÇOKGEN İÇ AÇILARI TOPLAMI---------------------------");
                    break;

                case 8:
                    Console.Write("\n------------ HAREKET PROBLEMLERİ Yol:Km  Hız: Km/Saat  Zaman:Saat---------------");
                    break;

                default:
                    break;
            }

            switch (secim)
            {
                case 1:
                    Console.Write("\nKısa kenarı Giriniz:  ");
                    kisakenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nUzun kenarı Giriniz:  ");
                    uzunkenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nALAN:   " + (uzunkenar * kisakenar));
                    break;

                case 2:
                    Console.Write("\nKenarı Giriniz:  ");
                    kisakenar = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nALAN:   " + (kisakenar * kisakenar));
                    break;


                case 3:
                    Console.Write("\nTaban Uzunluğunu Giriniz:  ");
                    kisakenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nYüksekliği Giriniz:  ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nALAN:   " + ((kisakenar * yukseklik) / 2));
                    break;


                case 4:
                    Console.Write("\nAlt Taban Uzunluğunu Giriniz:  ");
                    alttaban = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nÜst Taban Uzunluğunu Giriniz:  ");
                    usttaban = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nYüksekliği Giriniz:  ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nALAN:   " + (((alttaban + usttaban) * yukseklik) / 2));
                    break;

                case 5:
                    Console.Write("\nTaban Kenarını Giriniz:  ");
                    alttaban = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nYüksekliği Giriniz:  ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nALAN:   " + ((alttaban * yukseklik)));
                    break;

                case 6:
                    Console.Write("\nYarıçapı Giriniz:  ");
                    yaricap = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nYüksekliği Giriniz:  ");
                    yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nHACİM:   " + (pi * yaricap * yaricap * yukseklik));
                    break;

                case 7:
                    Console.Write("\nKenar Sayısını Giriniz:  ");
                    kenarsayisi = Convert.ToInt32(Console.ReadLine());


                    Console.Write("\nALAN:   " + ((kenarsayisi - 2) * 180));
                    break;

                case 8:

                    Console.Write("\nHangi hesaplamayı yapmak istiyorsunuz?\n\n 1.Yol\n 2.Hız \n 3.Zaman \n\n İstediğinizin numarasını yazıp 'ENTER' a basıp devam edin.\n\n");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            Console.Write("\nHızı Giriniz:  ");
                            v = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nZamanı Giriniz:  ");
                            t = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nYOL:   " + (v * t) + " km");
                            break;


                        case 2:
                            Console.Write("\nYolu Giriniz:  ");
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nZamanı Giriniz:  ");
                            t = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nHIZ:   " + (x / t) + " km/saat");
                            break;



                        case 3:
                            Console.Write("\nYolu Giriniz:  ");
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nHızı Giriniz:  ");
                            v = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nZAMAN:   " + (x / v) + " saat");
                            break;


                        default:
                            break;
                    }



                    break;



                default:
                    break;
            }



            Console.ReadLine();


        }
    }
}
