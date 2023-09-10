using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
    internal class GymMembership : IMembership
    {
        private readonly decimal _price;
        public string Name { get; }
        public string? Description { get; set; }

        public decimal Price
        {
            get => _price; 
            init => _price = Math.Max(value, 0);
        }

        public GymMembership(decimal price)
        {
            Price = price;
            Name = "Gym membership";
        }
    }
}
