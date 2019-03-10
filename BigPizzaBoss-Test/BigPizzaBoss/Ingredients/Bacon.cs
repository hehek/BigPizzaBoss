using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Bacon : Ingredient
    {
        private const string name = "бекон";
    
        public Bacon(Pizza pizza) : base(pizza, name)
        {

        }
    }
}
