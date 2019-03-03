using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;
using System.Threading;

namespace BigPizzaBoss.Pizzeria
{
     class PizzaDeveloper
    {
        List<Pizza> listPizzas = new List<Pizza>();
        readonly AllTheIgredients allTheIgredients = new AllTheIgredients();
        private readonly List<Pizza> listAllPizzas = new List<Pizza> {new PizzaMargherita(), new PizzaNeapolitano(), new PizzaPepperoni()};

        public void OrderPizza()
        {
            Pizza pizza;

            int key = -1;

            Console.WriteLine("Выбирите пиццу:");

            for(int i = 0; i < listAllPizzas.Count;i++)
            {
                Console.WriteLine($"{i+1}.{listAllPizzas[i].getName()} Цена: {listAllPizzas[i].getPrice()}");
            }

            key = Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString()) - 1;
            pizza = listAllPizzas[key];
            Console.WriteLine($"Вы выбрали {pizza.getName()}");

            Console.WriteLine("Добавить ингридиенты");

            for (int i = 0; i < allTheIgredients.listAllIngr.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{allTheIgredients.listAllIngr[i]}");
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
                    Console.WriteLine($"Вы выбрали {allTheIgredients.listAllIngr[key]}");
                    pizza = (Pizza)allTheIgredients.constructorInfos[key].Invoke(new object[] { pizza });
                }
            }

            Console.WriteLine("\nВаш заказ: " + pizza.getName());
            Console.WriteLine("Ингредиенты:");

            foreach (var list in pizza.getListIngredients())
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
            else if(key == 1)
            {
                Pizza.Check(listPizzas);
            }
        }
    }
}
