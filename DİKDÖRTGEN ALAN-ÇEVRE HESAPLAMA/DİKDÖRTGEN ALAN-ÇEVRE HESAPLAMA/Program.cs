using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİKDÖRTGEN_ALAN_ÇEVRE_HESAPLAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisa, uzun, cevre, alan;
            Console.Write("KISA KENAR:");
            kisa = Convert.ToInt32(Console.ReadLine());
            Console.Write("UZUN KENAR:");
            uzun = Convert.ToInt32(Console.ReadLine());
            alan =uzun*kisa;

            cevre = 2*(kisa+uzun);

            Console.WriteLine("ALAN:"+alan);

            Console.WriteLine("ÇEVRE:"+cevre);





        }
    }
}
