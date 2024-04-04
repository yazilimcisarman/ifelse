using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 0;
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı 0 dan büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0 dan küçük veya sıfırdır.");
            //}
            //.ToString(); //Degeri string yapmak için kullanıyoruz
            Console.WriteLine("Lütfen sayı giriniz.");

            int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi > 0)
            //{
            //    if(sayi > 5)
            //    {
            //        Console.WriteLine("Sayı 5 ten büyüktür");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 0 dan büyük ve 5 ten küçüktür");
            //    }
            //}
            //else if(sayi == 0)
            //{
            //    Console.WriteLine("Sayı sıfırdır");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı sıfırdan küçüktür.");
            //}

            //switch (sayi)
            //{
            //    case 4:
            //        Console.WriteLine("Sayı dörttür.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sayımız üçtür");
            //        break;
            //    default:
            //        Console.WriteLine("Sayı 4 veya 3 değildir.");
            //        break;

            //}

            //var deger = sayi == 4 ? "Sayımız dörttür" : "Sayımız dört değildir.";
            //var deger1 = sayi == 3 ? "Sayımız üçtür" : "SAyımız üç değildir.";
            
            //// koşul ? true: false;

            //Console.WriteLine(deger);
            Console.ReadLine();
        }
    }
}
