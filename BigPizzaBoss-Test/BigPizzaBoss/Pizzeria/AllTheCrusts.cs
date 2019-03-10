using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BigPizzaBoss.Pizzeria
{
    class AllTheCrusts
    {
        public List<ConstructorInfo> constructorInfos = new List<ConstructorInfo>();
        public List<string> listAllIngr = new List<string>();

        public AllTheCrusts()
        {
            MetodSetIngrAndPizzas();
        }

        private void MetodSetIngrAndPizzas()
        {
            Assembly asm = Assembly.LoadFrom("BigPizzaBoss.exe");
            Type baseClassCrusts = typeof(AllTheCrusts);

            foreach (Type t in asm.GetTypes())
            {

                if (t.IsSubclassOf(baseClassCrusts))
                {
                    listAllIngr.Add(t.GetField("name", BindingFlags.NonPublic | BindingFlags.Static).GetValue(t).ToString());
                    constructorInfos.Add(t.GetConstructor(new Type[] { baseClassCrusts }));
                }
            }
        }
    }
}
