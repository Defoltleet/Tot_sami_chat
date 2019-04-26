using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Hero
    {
        public int hp = 100;
        public int exp = 1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите имя: ");
            string name = Convert.ToString(Console.ReadLine());

        }
    }
}
