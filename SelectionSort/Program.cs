using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int dyili, yas;
            //DateTime yil;
            //yil = DateTime.Now;
            //Console.Write("Doğum yılını giriniz = ");
            //dyili = Convert.ToInt32(Console.ReadLine());
            //yas = yil.Date.Year - dyili;
            //Console.Write("Yaş = " + yas);



            float sayi;
            int i = 1;
            Console.Write("Bir Sayı Giriniz = ");
            sayi = Convert.ToUInt64(Console.ReadLine());
            while (sayi > 9) {

                sayi = sayi / 10;
                i++;
            }
            Console.Write("sayi "+i+" basamaklı");
            Console.ReadLine();

        }
    }
}
