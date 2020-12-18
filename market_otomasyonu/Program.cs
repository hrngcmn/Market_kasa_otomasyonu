using System;
namespace örn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            decimal i, k, t, fiyat, fiyat1, h, r, n;
            string sec, sec1, sec3, sec4;
            k = 0;
            h = 0;
            n = 0;
            Console.WriteLine(".....Hoşgeldiniz....");
            while (k < 2)
            {
                i = 0;
                t = 0;
                r = 0;
                Console.WriteLine("Yeni müşteri girişi yapmak ister misiniz?");
                Console.WriteLine(".....evet.....hayır.....");
                sec = Console.ReadLine();
                if (sec == "hayır")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("...... Yeni müşteri gelene kadar bekleyiniz .....");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                if (sec == "evet")
                {
                    n++;
                    while (t < 2)
                    {
                        i = 0;
                        Console.Write("Etiket fiyatını giriniz: ");
                        fiyat = Convert.ToDecimal(Console.ReadLine());
                        i = i + fiyat;
                        Console.WriteLine("Ödenecek " + i + " tl");
                        Console.WriteLine("Yeni etiket fiyatı girmek ister misiniz?");
                        Console.WriteLine(".....evet....hayır.....");
                        sec1 = Console.ReadLine();
                        if (sec1 == "hayır")
                        {
                            Console.WriteLine("ödenecek= " + i);
                            t = 3;
                        }
                        if (sec1 == "evet")
                        {
                            while (r < 2)
                            {
                                Console.WriteLine("Yeni etiket fiyatını giriniz: ");
                                fiyat1 = Convert.ToDecimal(Console.ReadLine());
                                i = i + fiyat1;
                                Console.WriteLine("Ödenecek= " + i + " tl");
                                Console.WriteLine("....Müşterinin işlemi bitti mi?");
                                Console.WriteLine("....Bitti ise ** son  ** yazın bitmediyise ** devam ** devam edin...");
                                sec3 = Console.ReadLine();
                                if (sec3 == "son")
                                {
                                    r = 3;
                                    t = 3;
                                    //k = 1;
                                }
                                if (sec3 == "devam")
                                {
                                    r = 1;
                                }
                            }
                            Console.WriteLine(i);
                            h = h + i;
                            Console.WriteLine("Tüm müşterilerden kazanılan parayı görmek ister misiniz?");
                            Console.WriteLine("....evet....hayır....");
                            sec4 = Console.ReadLine();
                            if (sec4 == "evet")
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("************************");
                                Console.WriteLine("Toplam kazanç");
                                Console.WriteLine(h);
                                Console.WriteLine("************************");
                                Console.WriteLine("Gelen müşteri sayısı");
                                Console.WriteLine(n);
                                Console.BackgroundColor = ConsoleColor.Cyan;
                            }
                            if (sec4 == "hayır")
                            {
                                k = 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
