using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basithesapmakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("birinci sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen bir işlem seçiniz \n +,-,*,/");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("yanlış işlem yaptınız");
                    break;

            }
            Console.ReadLine();
        }
    }
}
