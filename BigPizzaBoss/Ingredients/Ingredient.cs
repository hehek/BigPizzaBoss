using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    abstract class Ingredient : PizzaDecorator
    {
        protected string nameIgredient;
        protected double price;

        public Ingredient(Pizza pizza, string nameIgredient, double price) : base(pizza)
        {
            this.nameIgredient = nameIgredient;
            this.price = price;
        }

        public override List<string> getListIngredients()
        {
            listIngredients.AddRange(pizza.getListIngredients());
            listIngredients.Add(nameIgredient);
            
            return listIngredients;
        }

        public override double getPrice()
        {
            return pizza.getPrice() + price;
        }

        public override string getName()
        {
            return pizza.getName();
        }
    }
}
