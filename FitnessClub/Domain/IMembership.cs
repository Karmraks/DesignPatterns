using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
    internal interface IMembership
    {
        string Name { get; }
        string? Description { get; set; }
        decimal Price { get; init; }
    }
}
