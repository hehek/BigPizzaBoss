using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigPizzaBoss.Pizzas
{
    class PizzaPepperoni : Pizza
    {
        private const string name = "Пицца Пепперони";

        private List<string> listIng = new List<string> { "Корж", "Перец" };

        public PizzaPepperoni() : base()
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
            return 70;
        }
    }
}
