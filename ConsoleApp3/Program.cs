using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            Console.WriteLine("Введите номинал купюр:");
            string text = Console.ReadLine();
            int num;
            bool isParsed = int.TryParse(text, out num);
            if (!isParsed)
            {
                Console.WriteLine("Ошибка!");
            }

            money.SetNominal(num);

            Console.WriteLine("Введите количество купюр:");
            string text2 = Console.ReadLine();
            int num2;
            bool isParsed2 = int.TryParse(text2, out num2);

            if (!isParsed2)
            {
                Console.WriteLine("Ошибка!");
            }

            money.SetCount(num2);
            money.ShowNomCount();

            Console.WriteLine("Введите сумму товара:");
            int product = int.Parse(Console.ReadLine());
            money.MoneyToBuyGoods(product);
            money.HowManyPieces(product);
        }
    }
}




