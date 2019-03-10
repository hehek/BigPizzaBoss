using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzeria;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;

namespace BigPizzaBoss
{
    class Program
    {


        public static void OrderPizza()
        {
            List<Pizza> listPizzas = new List<Pizza>();
            AllTheIgredients allIgredients = new AllTheIgredients();
            List<PizzaDeveloper> listAllPizzasDeveloper = new List<PizzaDeveloper> { new MargaritaDeveloper(), new NeapolitanoDeveloper(), new PepperoniDeveloper() };
            List<Pizza> listAllPizzas = new List<Pizza> { new PizzaMargarita(), new PizzaNeapolitano(), new PizzaPepperoni() };

            Pizza pizza;

            int key = -1;

            Console.WriteLine("Выбирите пиццу:");

            for (int i = 0; i < listAllPizzas.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{listAllPizzas[i].GetName()} Цена: {listAllPizzas[i].GetPrice()}");
            }

            key = Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString()) - 1;
            pizza = listAllPizzasDeveloper[key].CreatePizza();
            Console.WriteLine($"Вы выбрали {pizza.GetName()}");

            Console.WriteLine("Добавить ингридиенты");

            for (int i = 0; i < allIgredients.listAllIngr.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{allIgredients.listAllIngr[i]}");
            }

            Console.WriteLine("0.Сделать заказ");

            while (true)
            {
                key = Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString()) - 1;

                if (key == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы выбрали {allIgredients.listAllIngr[key]}");
                    pizza = (Pizza)allIgredients.constructorInfos[key].Invoke(new object[] { pizza });
                }
            }

            Console.WriteLine("\nВаш заказ: " + pizza.GetName());
            Console.WriteLine("Ингредиенты:");

            foreach (var list in pizza.GetListIngredients())
            {
                Console.WriteLine(list);
            }

            Console.WriteLine();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Serve();

            listPizzas.Add(pizza);


            Console.WriteLine("\n1.Взять счет\n2.Заказать еще пиццы");
            key = Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString());

            if (key == 2)
            {
                OrderPizza();
            }
            else if (key == 1)
            {
                Pizza.Check(listPizzas);
            }
        }


        static void Main(string[] args)
        {
            OrderPizza();
            Console.ReadKey();
        }
    }
}
