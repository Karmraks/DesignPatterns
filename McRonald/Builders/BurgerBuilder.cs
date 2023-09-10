using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McRonald.Domain;

namespace McRonald.Builders
{
    public abstract class BurgerBuilder
    {
        protected Burger burger = new Burger();

        public Burger GetBurger() => burger;

        public abstract BurgerBuilder AddBun();
        public abstract BurgerBuilder AddPatty();
        public abstract BurgerBuilder AddSauce();
        public abstract BurgerBuilder AddTomato();
        public abstract BurgerBuilder AddCucumner();
        public abstract BurgerBuilder AddCheese();
    }
}
