﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
