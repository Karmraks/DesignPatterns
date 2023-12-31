﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attacker.Strategies;

namespace Attacker.Entities
{
    internal class Hero
    {
        private readonly string _name;
        private IWeapon? _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>");

            if (_weapon == null)
            {
                Console.WriteLine($"{_name} can't attack anyone. Set a weapon.");
                return;
            }

            Console.WriteLine($"{_name} stands up menacingly");
            Console.Write($"{_name} ");
            _weapon.Shoot();
            Console.WriteLine($"{_name} ceases to stand menacingly");
        }
}
}
