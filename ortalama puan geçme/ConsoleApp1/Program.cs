using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LÜTFEN İLK NOTUNUZU GİRİNİZ");
            float sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("LÜTFEN 2.NOTUNUZU GİRİNİZ");
            float sayi2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("LÜTFEN 3. NOTUNUZU GİRİNİZ");
            float sayi3=Convert.ToInt32(Console.ReadLine());
            float toplama=(sayi1+sayi2+sayi3)/3;
            if(toplama>85)
            {
                Console.WriteLine("A");

            }
            else if(toplama<85 && toplama>70)
            {
                Console.WriteLine("B");
            }
            if(toplama<50)
            {
                Console.WriteLine("KALDINIZ");
            }
            Console.ReadLine();
                    
                    

            

        }
    }
}
