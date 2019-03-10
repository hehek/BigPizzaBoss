using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss.Pizzas
{
    class PizzaMargarita : Pizza
    {
        private const string name = "Пицца Маргарита";
        private const double price = 60;

        public PizzaMargarita() : base()
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
