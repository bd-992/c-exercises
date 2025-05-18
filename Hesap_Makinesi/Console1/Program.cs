using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //HESAP MAKİNESİ 
        islem:
            double sonuc = 0;
            Console.Write("İşlem yapacağınız ilk sayıyı girin: ");
            string giris1 = Console.ReadLine();

            Console.Write("İşlem yapacağınız ikinci sayıyı girin: ");
            string giris2 = Console.ReadLine();

            double sayi1, sayi2;

            if(double.TryParse(giris1, out sayi1) && double.TryParse(giris2, out sayi2))
            {
                Console.WriteLine("\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\nq-Çıkış\n------------------------------------------");
                Console.Write("Seçiminiz: ");
                string secimStr = Console.ReadLine();

                if(secimStr == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                }

                char secim;
                if(!char.TryParse(secimStr, out secim))
                {
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                    goto islem;
                }
                
                switch(secim)
                {
                    case '1':
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, sonuc);
                        break;
                    case '2':
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, sonuc);
                        break;
                    case '3':
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("{0} x {1} = {2}", sayi1, sayi2, sonuc);
                        break;
                    case '4':
                        if(sayi2 == 0)
                        {
                            Console.WriteLine("Bölen 0 olamaz, lütfen başka bir sayı girin.");
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                        break;
                }

                goto islem;

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                goto islem;
            }
        }
    }
}
