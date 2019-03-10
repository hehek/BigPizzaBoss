using BigPizzaBoss.Ingredients;
using BigPizzaBoss.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Crusts
{
    class CheeseCrust : Crust
    {
        private const string name = "сырный корж";
        private const double price = 0.5;

        public CheeseCrust(Pizza pizza) : base(pizza, name)
        {

        }
    }
}
