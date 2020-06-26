using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventLocation
    {
        public enum LocationEnum
        {
            Venue,
            OnlineEvent,
            TBA
        }
        public int Id { get; set; }
        public LocationEnum LocationType { get; set; }
        public string Address { get; set; }
    }
}
