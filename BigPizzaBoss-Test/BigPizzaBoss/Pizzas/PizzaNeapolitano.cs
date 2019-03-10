using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Pizzas
{
    class PizzaNeapolitano : Pizza
    {
        private const string name = "Пицца Неаполитана";
        private const double price = 50;

        public PizzaNeapolitano() : base()
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
