using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Pizza
    {
        private string baseType;
        private string[] toppings;
        private int bakeTime;

        public Pizza(string baseType, string[] toppings)
        {
            this.baseType = baseType;
            Array.Copy(toppings, this.toppings, toppings.Length);
        }

        public string MakePizza()
        {
            if(CookBasePizza(baseType))
                if(AddToppings(toppings))
                    if(CookPizza(baseType))
                       return "Pizza muchana!!!";
            return "Error";

        }

        private bool CookBasePizza(string baseType)
        {
            return true;
        }
        private bool AddToppings(string[] toppings)
        {
            for (int i=0; i< toppings.Length; i++)
            { }
            return true;
        }
        private bool CookPizza(string baseType)
        {
            if(baseType == "thin")
                for (int i = 0; i < 60000; i++)
                { }
            else
                for (int i = 0; i < 120000; i++)
                { }
            return true;
        }
    }
}
