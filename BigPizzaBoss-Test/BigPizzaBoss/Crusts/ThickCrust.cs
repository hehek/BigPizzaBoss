using BigPizzaBoss.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Crusts
{
    class ThickCrust : Crust
    {
        private const string name = "толстый корж";

        public ThickCrust(Pizza pizza) : base(pizza, name)
        {

        }
    }
}