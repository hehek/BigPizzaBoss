using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Chilli : Ingredient
    {
        private const string name = "перец чилли";
        private const double price = 4.5;

        public Chilli(Pizza pizza) : base(pizza, name, price)
        {

        }
    }
}
