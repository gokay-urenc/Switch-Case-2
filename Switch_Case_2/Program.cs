using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir gün adı giriniz: ");
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "Pazartesi":
                    Console.Write("Haftanın 1. günüdür.");
                    break;
                case "Salı":
                    Console.Write("Haftanın 2. günüdür.");
                    break;
                case "Çarşamba":
                    Console.Write("Haftanın 3. günüdür.");
                    break;
                case "Perşembe":
                    Console.Write("Haftanın 4. günüdür.");
                    break;
                case "Cuma":
                    Console.Write("Haftanın 5. günüdür.");
                    break;
                case "Cumartesi":
                    Console.Write("Haftanın 6. günüdür.");
                    break;
                case "Pazar":
                    Console.Write("Haftanın 7. günüdür.");
                    break;
                default:
                    Console.Write("Böyle bir gün yoktur.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
// Kullanıcıdan alınan günün haftanın kaçıncı günü olduğunu söyleyen program.