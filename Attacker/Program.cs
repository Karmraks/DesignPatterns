using System.Net.WebSockets;
using Attacker.Entities;
using Attacker.Strategies;

Hero hero = new Hero("Rayman");
hero.SetWeapon(new WaterGun());
hero.Attack();