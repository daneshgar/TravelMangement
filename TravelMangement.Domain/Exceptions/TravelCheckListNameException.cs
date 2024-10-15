using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMangement.shared.Abstractions.Exceptions;

namespace TravelMangement.Domain.Exceptions
{
    public class TravelCheckListNameException : TravelCheckListEception
    {
        public TravelCheckListNameException() : base("error: TravelCheckListName cannot be Empty  ")
        {
        }
    }
}
