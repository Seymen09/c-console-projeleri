using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz Seçeneği Seçiniz");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : "+bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Bakiyeyi Giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                Console.WriteLine("Kalan Tutar :Bakiye-cekilecek_tutar");
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Yazınız");
                int yatırılacak_tutae=Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                Console.WriteLine("bakiyeniz: bakiye+yatirilacak_tutar");

            }
            
               


















        }
    }
}
