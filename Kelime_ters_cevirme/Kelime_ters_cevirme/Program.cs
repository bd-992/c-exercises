using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_ters_cevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Tersini öğrenmek için kelime veya cümle girin:");
                string kelime = Console.ReadLine();

                char[] harfler = kelime.ToCharArray();
                Array.Reverse(harfler);
                string tersKelime = new string(harfler);

                Console.WriteLine("Ters hali: " + tersKelime);
            }
        }
    }
}
