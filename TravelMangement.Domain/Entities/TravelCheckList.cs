using TravelMangement.Domain.ValueObjects;

namespace TravelMangement.Domain.Entities
{
    internal class TravelCheckList
    {
        public TravelCheckList(TravelCheckListId id,
             TravelCheckListName name,
             Destination  destination)
        {
            Id = id;
            Name = name; 
            Destination = destination;

        }

        public TravelCheckListId Id { get;  set; }
        public TravelCheckListName  Name { get; set; }
        public Destination Destination { get; set; }

        
    }
}
