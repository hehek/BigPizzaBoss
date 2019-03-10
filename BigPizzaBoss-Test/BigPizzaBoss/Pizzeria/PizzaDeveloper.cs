using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;
using System.Threading;

namespace BigPizzaBoss.Pizzeria
{
    abstract class PizzaDeveloper
    {
        public PizzaDeveloper()
        {

        }

        public abstract Pizza CreatePizza();
    }
}
