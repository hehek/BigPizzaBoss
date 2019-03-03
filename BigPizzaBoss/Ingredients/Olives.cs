using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Olives : Ingredient
    {
        private const string name = "маслины";
        private const double price = 6;

        public Olives(Pizza pizza) : base(pizza, name, price)
        {

        }
    }

}