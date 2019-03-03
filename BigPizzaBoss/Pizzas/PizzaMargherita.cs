using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Pizzas
{
    class PizzaMargherita : Pizza
    {
        private const string name = "Пицца Маргарита";

        private List<string> listIng = new List<string> { "Корж", "Перец" };

        public PizzaMargherita() : base()
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
            return 60;
        }
    }
}
