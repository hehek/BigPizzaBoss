using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Ham : Ingredient
    {
        private const string name = "ветчина";

        public Ham(Pizza pizza) : base(pizza, name)
        {

        }

    }
}
