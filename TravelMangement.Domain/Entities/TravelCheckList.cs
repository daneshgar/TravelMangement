using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMangement.Domain.Entities
{
    internal class TravelCheckList
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public string Destination { get; set; }

    }
}
