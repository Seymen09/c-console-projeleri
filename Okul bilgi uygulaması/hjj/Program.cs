using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol=true;
            Ogrenci ogrenci1 = new Ogrenci("SEYMEN","SONGÜLTEKİN",85037,75,65,81,"SİVAS CUMHURİYET ÜNİ");
            Console.WriteLine("UYGULAMAMIZA HOŞGELDİNİZ... YAPMAK İSTEDİĞİNİZ SEÇENEĞİ SEÇİNİZ");
            
            
            while(kontrol)
            {
                IslemleriGoster();
                string secim=Console.ReadLine();
                switch (secim)
                { 
                    case "1":

                        ogrenci1.ogrencibilgilerigoster();
                            break;
                    case "2":    
                   
                     double ogrenciortalama= ogrenci1.ogrencinotubul();
                        Console.WriteLine("ORTALAMANIZ:"+ogrenciortalama);
                        break;
                    case "3":
                        ogrenci1.okulgetir();
                        break;
                    case "4":
                        kontrol=false;
                        break;

                        






                }



            }














        }
        
            









        static void IslemleriGoster()
        {
            Console.WriteLine("1-ÖĞRENCİ BİLGİLERİNİ GÖSTER");
            Console.WriteLine("2-ÖĞRENCİ ORTALAMASINI GÖSTER");
            Console.WriteLine("3-ÖĞRENCİ OKUL İSMİNİ GÖSTER");
            Console.WriteLine("4-ÇIKIŞ");
        }
















    }

}
