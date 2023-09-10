using McRonald.Builders;
using McRonald.Domain;

BurgerBuilder cheeseBurgerBuilder = new CheeseBurgerBuilder();
Sheff sheff = new Sheff();
sheff.MakeBurger(cheeseBurgerBuilder);
Burger cheeseBurger = cheeseBurgerBuilder.GetBurger();

Console.WriteLine($"Bun: {cheeseBurger.Bun}");
Console.WriteLine($"Patty: {cheeseBurger.Patty}");
Console.WriteLine($"Sauce: {cheeseBurger.Sauce}");

