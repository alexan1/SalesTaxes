using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int list = 1; list < 4; list++)
            {
                IEnumerable<ShoppingCartItem> itemList = Util.GetItemsList(list);
                Util.PrintRecept(itemList);                
            }
            Console.ReadLine();
        }
            
    }
}
