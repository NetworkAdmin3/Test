using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplampara = 10000;

            Console.WriteLine("Atm'ye Hoşgeldiniz Lütfen Kartınızı Yerleştiriniz..");
            Console.Write("Şifrenizi giriniz : ");
            int sifre = Convert.ToInt32(Console.ReadLine());


            if (sifre == 4423)
            {
                Console.WriteLine("Giriş Yapılıyor Lütfen Bekleyiniz...");
            }



            else if (sifre != 4423)
            {
                Console.WriteLine("Şifreniz Yanlış! 2 hakkınız kaldı ");
                Environment.Exit(0);
            }


            Console.Write("Yapmak istediğiniz İşlemi Tuşlayınız para çekme (1) para yatırma (2) bakiyeni görüntüle (3) \n ");
            int islem = Convert.ToInt32(Console.ReadLine());

            

            if (islem == 1)
            {
                Console.WriteLine("Kaç TL para çekmek istiyorsunuz ? :");
                int paracekme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Para Çekilme işlemi Başarıyla Gerçekleşti Şuanki Bakiyeniz");
                Console.WriteLine(toplampara -= paracekme);
            }

            
            else if (islem == 2)
            {
                Console.Write("Kaç TL Yatırmak İstiyorsunuz? :");
                int parayatirma = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Para Yatırma İşlemi Başarıyla Gerçekleşti Şuanki Bakiyeniz.");
                Console.WriteLine(toplampara += parayatirma);
            }

            else if (islem == 3)
            {
                Console.WriteLine($"Şuanki Bakiyeniz Toplam : {toplampara}");

            }

            else
            {
                Console.WriteLine("Yanlış Veya Hatalı Tuşlama Yaptınız");
            }


            
            


        }
    }
}
