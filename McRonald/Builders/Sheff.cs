using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McRonald.Domain;

namespace McRonald.Builders
{
    public class Sheff
    {
        public void MakeBurger(BurgerBuilder burger)
        {
            burger.AddBun().AddCheese().AddCucumner().AddPatty().AddSauce().AddTomato();
        }
    }
}
