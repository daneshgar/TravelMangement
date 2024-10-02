using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMangement.shared.Abstractions.Exceptions
{
    public abstract class TravelCheckListEception :Exception
    {
        protected TravelCheckListEception(string message):base(message)
        {
            
        }
    }
}
