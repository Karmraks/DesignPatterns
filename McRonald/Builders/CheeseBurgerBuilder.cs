using McRonald.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McRonald.Builders
{
    public class CheeseBurgerBuilder : BurgerBuilder
    {
        public override BurgerBuilder AddBun()
        {
            burger.Bun = "Regular Bun";
            return this;
        } 
        public override BurgerBuilder AddPatty()
        {
            burger.Patty = "Beef Patty";
            return this;
        }
        public override BurgerBuilder AddSauce()
        {
            burger.Sauce = "Ketchup";
            return this;
        }
        public override BurgerBuilder AddTomato()
        {
            burger.Tomato = "2 tomato slices";
            return this;
        }
        public override BurgerBuilder AddCucumner()
        {
            burger.Cucumber = null;
            return this;
        }
        public override BurgerBuilder AddCheese()
    {
            burger.Cheese = "Cheddar";
            return this;
        }
}
}
