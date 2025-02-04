using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = new PC();
            pc1.mod = "AMD";
            pc1.freq = 2;
            pc1.ram = 8;
            pc1.mem = 256;

            Console.WriteLine();
            //
            Console.WriteLine("Модель: ");
            string mod = Console.ReadLine();
            Console.WriteLine("Тактовая частота: ");
            int frq = int.Parse(Console.ReadLine());
            Console.WriteLine("Оперативная память: ");
            int rm = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем памяти: ");
            int mem = int.Parse(Console.ReadLine());

            pc1.Info();
            PC pc2 = new PC(mod, frq, rm, mem);
            Console.WriteLine($"{pc2.ToString()}");
            //
            PC pc3 = new PC("Intel", 3, 32, 512);
            Console.WriteLine($"{pc3.ToString()}");
            Console.ReadKey();

        }
    }
}
