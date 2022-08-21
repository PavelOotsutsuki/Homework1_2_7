using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int extraSymbols=2;
            Console.Write("Введите имя: ");
            string name=Console.ReadLine();
            Console.Write("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            int nameLenght = name.Length;

            for(int i = 0; i < nameLenght+extraSymbols; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            Console.Write(symbol);
            Console.Write(name);
            Console.WriteLine(symbol);

            for (int i = 0; i < nameLenght + extraSymbols; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}