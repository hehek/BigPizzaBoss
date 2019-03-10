using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Crusts;

namespace BigPizzaBoss.Ingredients
{
    class ThinCrust : Crust
    {
        private const string name = "тонкий корж";

        public ThinCrust(Pizza pizza) : base(pizza, name)
        {

        }
    }
}
