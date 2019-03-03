using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzeria;

namespace BigPizzaBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDeveloper pizzaDeveloper = new PizzaDeveloper();
            pizzaDeveloper.OrderPizza();

            Console.ReadKey();
        }
    }
}
