using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;
using BigPizzaBoss.Crusts;

namespace BigPizzaBoss.Pizzeria
{
    class PepperoniDeveloper : PizzaDeveloper
    {
        public PepperoniDeveloper() : base()
        {

        }

        public override Pizza CreatePizza()
        {
            Pizza pizza = new PizzaPepperoni();
            pizza = new CheeseCrust(new Sausage(pizza));

            return pizza; 
        }
    }
}
