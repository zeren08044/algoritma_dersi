namespace ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrisi oluşturma ve yazdırma

            Console.Write("N değerini giriniz: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[N, N];
            Random rnd = new Random();

            Console.WriteLine("Matris:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                    Console.Write(" " + matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Max tekrar ve tekrar eden sayı

            int maxtekrar = matris[0, 0];
            int tekrar_sayi = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int sayi2 = matris[i, j];
                    int sayac = 0;
                    for (int x = 0; x < N; x++)
                    {
                        for (int y = 0; y < N; y++)
                        {
                            if (matris[x, y] == sayi2)
                                sayac++;
                        }
                    }
                    if (sayac > maxtekrar || (sayac == maxtekrar && sayi2 < maxtekrar))
                    {
                        maxtekrar = sayac;
                        tekrar_sayi = sayi2;
                    }
                }
            }

            //Negatif sayı ve Toplamı
            //Köşegenlerin Toplamı Ve Çarpımı

            int neg_toplam = 0;
            for (int i = 0; i < N; i++)
            {
                neg_toplam = neg_toplam + matris[i, i];
            }
            int kosegen_carpim = 1;
            for (int i = 0; i < N; i++)
            {
                kosegen_carpim = kosegen_carpim * matris[i, N - 1 - i];
            }
            int negatif = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatif++;
                    }
                }
            }

            int kosegen_toplam = 0, asal = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    kosegen_toplam = kosegen_toplam + matris[i, j];
                    asal++;
                }
            }

            int asalAdet = 0;
            int asalToplam = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int sayi2 = matris[i, j];
                    bool asal1 = true;

                    if (sayi2 < 2)
                        asal1 = false;
                    else
                    {
                        for (int k = 2; k * k <= sayi2; k++)
                        {
                            if (N % k == 0)
                            {
                                asal1 = false;
                                break;
                            }
                        }
                    }
                    if (asal1)
                    {
                        asalToplam += sayi2;
                        asalAdet++;
                    }
                }
            }
            if (asalAdet == 0)
                Console.WriteLine("Asal sayı yok.");
            else
            {
                double ortalama = asalToplam / (double)asalAdet;
                Console.WriteLine("Asal sayıların ortalaması: " + ortalama);
            }

            //İstenilenler 
            Console.WriteLine($"Asal Köşegenlerin Toplamı: {kosegen_toplam}");
            Console.WriteLine($"Yardımcı Köşegenlerin Çarpımı: {kosegen_carpim}");
            Console.WriteLine($"Matristeki Negatif Sayı Adeti: {negatif}");
            Console.WriteLine($"En Fazl Tekrar Eden Sayı: {tekrar_sayi}  Tekrar Miktarı: {maxtekrar}");
        }
    }
}
