using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Sausage : Ingredient
    {
        private const string name = "колбаса";

        public Sausage(Pizza pizza) : base(pizza, name)
        {

        }
    }
}
