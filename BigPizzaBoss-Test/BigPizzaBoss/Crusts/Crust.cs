using BigPizzaBoss.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Crusts
{
    abstract class Crust : PizzaDecorator
    {
        protected string nameIngredient;
        protected double price;

        public Crust (Pizza pizza, string nameIngredient, double price) : base(pizza)
        {
            this.nameIngredient = nameIngredient;
            this.price = price;
        }

        public Crust(Pizza pizza, string nameIngredient) : base(pizza)
        {
            this.nameIngredient = nameIngredient;
        }

        public override List<string> GetListIngredients()
        {
            listIngredients.AddRange(pizza.GetListIngredients());
            listIngredients.Add(nameIngredient);

            return listIngredients;
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() + price;
        }

        public override string GetName()
        {
            return pizza.GetName();
        }
    }
}
