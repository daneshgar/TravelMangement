using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMangement.Domain.Exceptions;

namespace TravelMangement.Domain.ValueObjects
{
    public record  TravelCheckListName
    {
        public string Value { get; set; }
        public TravelCheckListName( string Value) 
        {
            if(string.IsNullOrWhiteSpace(Value)) 
                throw new TravelCheckListNameException();
            Value = Value.Trim();
                
        }
        public static implicit operator TravelCheckListName(string name)=>new (name);
        public static implicit operator string(TravelCheckListName name) =>name.Value;
        
    }
}
