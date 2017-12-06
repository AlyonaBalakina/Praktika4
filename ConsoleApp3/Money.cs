using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Money

    {
        private int nominal;
        private int count;

        public Money() { }
        public int GetNominal() { return nominal; }
        public void SetNominal(int par)
        {
            this.nominal = par;
        }
        public int GetCount() { return count; }
        public void SetCount(int count)
        {
            this.count = count;
        }
        public void ShowNomCount()
        {
            Console.WriteLine(GetNominal() * GetCount() + " тенге");
        }

        public void MoneyToBuyGoods(int product)
        {
            if ((GetNominal() * GetCount()) > product) Console.WriteLine("Хватит денежных средст на покупку.");
            else Console.WriteLine("Не хватит денежных средст на покупку!");
        }
        public void HowManyPieces(int product)
        {
            int pieces = (GetNominal() * GetCount()) / product;
            Console.WriteLine("Количество товара: " + pieces);
        }
    }
}
