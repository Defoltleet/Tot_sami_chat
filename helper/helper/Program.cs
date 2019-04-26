using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace helper
{
    class Program
    {
        public void Calc() // сам калькулятор
        {

        }
        static void Main(string[] args)
        {
            /* bool pravda = false;
             if (pravda)
             {
                 Console.WriteLine("Zhi est");
                 Console.ReadLine();
             

            Console.WriteLine("Vpishi chislo, chelovek: ");
            Console.WriteLine("Мой любимый писатель {0} или {1,20} ?", "Лавкрафт", "Аберкромби"); // можно взять на заметку
            Console.WriteLine("22/7 = {0:#.##}", 22.0 / 721.0); //округление
            Console.WriteLine(@"Еще, как оказалось
есть и такая
""тема""");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 1; j <= a; j++) Console.WriteLine("Stroka num " + j);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Done");
            */
            string arg = Console.ReadLine();
            for (int i = 0; i >= arg.Length;i++)
            {
                if (arg[i] is int) Console.WriteLine(arg[i]);
            }
            Console.WriteLine(arg);
            char[] charray = { 't', 'е', 's', 't' };
            string str = new string(charray);
            Console.WriteLine(str);
           /* Console.Clear();
            Console.WriteLine("Введите пароль: ");
            int cor = Convert.ToInt32(Console.ReadLine());
            if (cor == 1315)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Пароль верный");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Чо нада?");
                Console.WriteLine("/сalc - калькулятор");
                Console.WriteLine("/bot - самый простой бот");
                Console.WriteLine("/kur - замена букв в тексте");
                Console.ForegroundColor = ConsoleColor.White;
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "/calc":

                        break;

                    case "/bot":
                        Console.Clear();
                        while (true)
                        {
                            string botAns = Console.ReadLine();
                            Console.WriteLine("bot: " + botAns);
                        }
                        break;

                    default:
                        Console.WriteLine("Такой функции нет");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пароль неверен");
            }*/
            Console.ReadKey();
            
            

        }
    }
}
