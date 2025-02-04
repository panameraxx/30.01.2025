using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Build house1 = new Build();
            house1.title = "Квартира";
            house1.size = 80;
            house1.residents = 2;
            house1.ShowInfo();
            Console.WriteLine();

            // Второй дом
            Build house2 = new Build("Отель", 6000, 1500);
            Console.WriteLine($"{house2.ToString()}");
            Console.WriteLine();

            Console.Write("Название строения: ");
            string title = Console.ReadLine();
            Console.Write("Площадь строения: ");
            double size = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int residents = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int floors = int.Parse(Console.ReadLine());

            Build house3 = new Build(title, size, residents, floors);
            Console.WriteLine($"{house3.ToString()}");
            Console.ReadKey();

        }
    }
}
