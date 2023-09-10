using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal class GymAndPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymAndPoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            var membership = new GymAndPoolMembership(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
