using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    abstract class Ingredient : PizzaDecorator
    {
        protected string nameIngredient;
        protected double price;

        public Ingredient(Pizza pizza, string nameIngredient, double price) : base(pizza)
        {
            this.nameIngredient = nameIngredient;
            this.price = price;
        }

        public Ingredient(Pizza pizza, string nameIngredient) : base(pizza)
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
