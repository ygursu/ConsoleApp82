using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenkenarlarigirilenucgenincevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Klavyeden kenarları girilen üçgenin çevresini bulan C# programını yazınız.
                Formül : 
                k1+k2+k3
             
             */

            int kenar1, kenar2, kenar3
            Console.WriteLine("Üçgenin 1. kenarını giriniz");
            kenar1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin 2. kenarını giriniz");
            kenar2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin 3. kenarını giriniz");
            kenar3 = Int32.Parse(Console.ReadLine());

            cevre = kenar1 + kenar2 + kenar3;

            Console.WriteLine("Üçgenin çevresi=" + cevre);
            Console.ReadLine();


        }
    }
}