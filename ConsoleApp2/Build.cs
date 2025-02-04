using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Build
    {
        public string title;
        public double size;
        public int residents;
        public int floors;

        public Build() { }

        public Build(string title)
        {
            this.title = title;
        }
        public Build(string title, double size) : this(title)
        {
            this.size = size;
        }
        public Build(string title, double size, int residents) : this(title, size)
        {
            this.residents = residents;
        }
        public Build(string title, double size, int residents, int floors) : this(title, size, residents)
        {
            this.floors = floors;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"В доме: {title}\t Площадью: {size}\t Квадратных метров живет: {residents} чел," +
                $"на человека - {size / residents:f2} кв. метров");
        }
        public override string ToString()
        {
            return $"В доме {title} площадью {size} кв. метров живёт {residents} чел, " +
                $"на человека - {size / residents:f2} кв. метров";
        }
    }

}
