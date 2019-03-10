using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss.Pizzas
{
    class PizzaPepperoni : Pizza
    {
        private const string name = "Пицца Пепперони";
        private const double price = 70;

        public PizzaPepperoni() : base()
        {

        }

        public override string GetName()
        {
            return name;
        }

        public override List<string> GetListIngredients()
        {
            return listIngredients;
        }

        public override double GetPrice()
        {
            return price;
        }
    }
}
