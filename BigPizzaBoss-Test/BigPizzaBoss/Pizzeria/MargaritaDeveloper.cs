using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss.Pizzeria
{
    class MargaritaDeveloper : PizzaDeveloper
    {
        public MargaritaDeveloper() : base()
        {

        }

        public override Pizza CreatePizza()
        {
            Pizza pizza = new PizzaPepperoni();
            pizza = new ThinCrust(new Ham(pizza));

            return pizza;
        }
    }
}
