using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BigPizzaBoss.Pizzeria.AllTheIgredients;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss.Pizzas
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(Pizza pizza) : base()
        {
            this.pizza = pizza;
        }
        
    }
}
