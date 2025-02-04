using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
        internal class PC
        {
            public string mod;
            public int freq;
            public int ram;
            public int mem;

            public PC() { }

            public PC(string mod)
            {
                this.mod = mod;
            }

            public PC(string mod, int freq) : this(mod)
            {
                this.freq = freq;
            }

            public PC(string mod, int freq, int ram) : this(mod, freq)
            {
                this.ram = ram;
            }

            public PC(string mod, int freq, int ram, int mem) : this(mod, freq, ram)
            {
                this.mem = mem;
            }

            public void Info()
            {
                Console.WriteLine($"Модель: {mod}\t Тактовая частота: {freq}\t ОЗУ: {ram} ГБ\t Память: {mem} ГБ");
            }

            public override string ToString()
            {
                return $"Модель: {mod}\t Тактовая частота: {freq}\t ОЗУ: {ram} ГБ\t Память: {mem} ГБ";
            }
        }  
}
