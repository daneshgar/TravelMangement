using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMangement.Domain.Exceptions;

namespace TravelMangement.Domain.ValueObjects
{
    public record TravelCheckListId
    {
        public Guid Value { get; } 
        public  TravelCheckListId (Guid vale)
        {
            if (vale == Guid.Empty)
            {
                throw new TravelCheckListIdException();

            }
            Value = vale;
        }
        public static implicit operator Guid(TravelCheckListId id) => id.Value;
        public static implicit operator TravelCheckListId(Guid id)=>new(id);

    }
}
