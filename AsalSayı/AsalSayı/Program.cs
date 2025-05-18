using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.Write("Bir sayı girin:");
                string giris = Console.ReadLine();
                int sayi;

                if (int.TryParse(giris, out sayi) && sayi > 1)
                {
                    bool asal = true;

                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            asal = false;
                            break;
                        }
                    }

                    if (asal)
                    {
                        Console.WriteLine($"{sayi} bir asal sayıdır.");
                    }
                    else
                    {
                        Console.WriteLine($"{sayi} bir asal sayı değildir.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen 2 veya daha büyük bir sayı girin.");
                }
            }
        }
    }
}
