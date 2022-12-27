using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYI_TAHMİN_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞGELDİNİZ");
            int tutulan, tahmin, hak = 5;
            Random random = new Random();
            tutulan = random.Next(1, 30);
           
            while (true)
            {
                if(hak<=0)
                {
                    Console.WriteLine("HAKKINIZ KALMAMIŞTIR");
                    break;
                }

                Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ");
                tahmin = Convert.ToInt32(Console.ReadLine());


                if (tutulan==tahmin)
                {
                    Console.WriteLine("TEBRİKLER KAZANDINIZ");
                    break;
                }
                else if(tutulan>tahmin)
                {
                    Console.WriteLine("ÇIKINIZ");
                }

                else
                {
                    Console.WriteLine("İNİNİZ");
                }
                hak--;







            }


            











        }
    }
}
