using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIBONACCI DİZİSİ
            Console.Write("Kaç terimlik dizi yazdırmak istersiniz :");
            string giris = Console.ReadLine();
            int n;

            if(int.TryParse(giris, out n) && n > 0)
            {
                long a = 0, b = 1, c;

                Console.Write("Fibonacci dizisi:");

                for(int i = 1; i<=n; i++)
                {
                    Console.Write(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            else
            {
                Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
            }
            Console.WriteLine("\nProgram sona erdi.");
        }
    }
}
