using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class BellPepper : Ingredient
    {
        private const string name = "сладкий перец";
        private const double price = 4.5;

        public BellPepper(Pizza pizza) : base(pizza, name, price)
        {

        }
    }
   
}
