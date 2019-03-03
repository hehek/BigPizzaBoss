using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;
using BigPizzaBoss.Ingredients;
using System.Reflection;

namespace BigPizzaBoss.Pizzeria
{
    class AllTheIgredients
    {
        public List<ConstructorInfo> constructorInfos = new List<ConstructorInfo>();
        public List<string> listAllIngr = new List<string>();

        public AllTheIgredients()
        {
            MetodSetIngr();
        }

        public void MetodSetIngr()
        {
            Assembly asm = Assembly.LoadFrom("BigPizzaBoss.exe");
            Type baseClass = typeof(Ingredient);

            foreach (Type t in asm.GetTypes())
            {
                if (t.IsSubclassOf(baseClass))
                {
                    listAllIngr.Add(t.GetField("name", BindingFlags.NonPublic | BindingFlags.Static).GetValue(t).ToString());
                    constructorInfos.Add(t.GetConstructor(new Type[] { baseClass }));
                }
            }
        }
    }
}
