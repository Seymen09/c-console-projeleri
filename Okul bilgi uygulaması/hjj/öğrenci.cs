using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjj
{
    public class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrno;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Ogrenci(string _isim, string _soyisim,int _ogrno,int _vize1,int _vize2,int _final,string _okulismi)

        {

            isim= _isim;
            soyisim= _soyisim;
            ogrno= _ogrno;
            vize1= _vize1;
            vize2= _vize2;
            final= _final;
            okulismi= _okulismi;
        }









        public void ogrencibilgilerigoster()
        {
            
            
                Console.WriteLine("ÖĞRENCİ İSMİ:" + isim);
                Console.WriteLine("ÖĞRECİ SOYİSMİ:" + soyisim);
                Console.WriteLine("ÖĞRENCİ NUMARASI:" + ogrno);
                Console.WriteLine("VİZE1:" + vize1);
                Console.WriteLine("VİZE2:" + vize2);
                Console.WriteLine("FİNAL:" + final);
                Console.WriteLine("OKUL İSMİ:" + okulismi);
            

        }
        public double ogrencinotubul()
        {
            double ortalama= vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;


        }
        public void okulgetir()
        {
            Console.WriteLine("ÖĞRENCİ OKUL İSİMİ:"+okulismi);

        }






    }
}
