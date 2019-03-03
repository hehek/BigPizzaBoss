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

        private List<string> listIng = new List<string> { "Корж", "Перец" };

        public PizzaNeapolitano() : base()
        {

        }

        public override string getName()
        {
            return name;
        }

        public override List<string> getListIngredients()
        {
            return listIng;
        }

        public override double getPrice()
        {
            return 50;
        }
    }
}
