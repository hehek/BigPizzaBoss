using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Tomato : Ingredient
    {
        private const string name = "томат";
   
        public Tomato(Pizza pizza) :base(pizza, name)
        {

        }
    }
}
