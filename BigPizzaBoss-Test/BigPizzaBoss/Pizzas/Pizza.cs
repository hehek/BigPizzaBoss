using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss.Pizzas
{
    abstract class Pizza
    {
        protected List<string> listIngredients = new List<string>();

        public Pizza()
        {
            
        }

        public abstract List<string> GetListIngredients();

        public abstract double GetPrice();

        public abstract string GetName();

        public static void Check(List<Pizza> pizzas)
        {
            double sumPrice = 0;
            Console.WriteLine("Счет:");

            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine($"{pizza.GetName()} Цена: " + pizza.GetPrice());
                sumPrice += pizza.GetPrice();
                //foreach (var list in getListIngredients())
                //{
                //    Console.WriteLine(list);
                //}
            }

            Console.WriteLine($"Общая сумма: {sumPrice}");
        }

        public void Prepare()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Пицца готовится");
        }

        public void Bake()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Пицца печется");
        }

        public void Cut()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Происходит нарезка пиццы");
        }

        public void Serve()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Пицца подана");
        }
    }
}
